using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class UIForm : Form
    {
        private GameController _GameController;

        public UIForm()
        {
            InitializeComponent();
            _GameController = new GameController();
        }

        /// <summary>
        /// Updates the form labels / text-boxes with current game data
        /// </summary>
        private void UpdateForm()
        {
            if (_GameController.GameOver)
            {
                groupBoxPlayerChoice.Enabled = false;
                MessageBox.Show("Game Over - please start a new game!", "GAME OVER");
            }
            else
            {
                // Update Game Result text box colour according to result
                textBoxGameResult.BackColor = DefaultBackColor;
                switch (_GameController.PlayerStatus)
                {
                    case GameResult.DRAW:
                        textBoxGameResult.ForeColor = Color.Blue;
                        break;
                    case GameResult.LOSE:
                        textBoxGameResult.ForeColor = Color.Red;
                        break;
                    case GameResult.WIN:
                        textBoxGameResult.ForeColor = Color.Green;
                        break;
                }

                // Update Scores on form controls
                textBoxPlayerChoice.Update();
                textBoxAIChoice.Update();
                textBoxAIScore.Update();
                textBoxPlayerScore.Update();
                textBoxGameResult.Update();
            }
        }

        /// <summary>
        /// Players user choice (based on button selected) against AI choice and gets result, assigning to applicable form controls
        /// </summary>
        /// <param name="choice"></param>
        private void PlayChoice(string choice)
        {
            textBoxPlayerChoice.Text = choice;
            textBoxAIChoice.Text = _GameController.PlayChoice(choice);
            textBoxAIScore.Text = _GameController.AIScore.ToString();
            textBoxPlayerScore.Text = _GameController.PlayerScore.ToString();
            textBoxGameResult.Text = _GameController.PlayerStatus.ToString();

            UpdateForm();

            // Start Countdown for before allowing next choice
            if (!_GameController.GameOver)
            {
                StartCountdown();
            }
        }

        /// <summary>
        /// Clears all user-based labels and textboxes on form
        /// </summary>
        private void ClearForm()
        {
            textBoxAIChoice.Clear();
            textBoxPlayerChoice.Clear();
            textBoxAIScore.Clear();
            textBoxPlayerScore.Clear();
            textBoxGameResult.Clear();
            textBoxGameResult.ForeColor = Color.Black;
        }

        /// <summary>
        /// Uses a Stopwatch to initiate a 3 second timer in between player choices
        /// </summary>
        private void StartCountdown()
        {
            const int START_TIME = 2;
            const int END_TIME = 0;
            const int DELAY = 1000;     // milliseconds
            int countDown;
            Stopwatch sw = new Stopwatch();

            // Disable Player Choice controls on form
            groupBoxPlayerChoice.Enabled = false;

            // Iterate through countdown
            for (countDown = START_TIME; countDown >= END_TIME; countDown--)
            {
                sw.Start();
                do
                {
                    // Get equivalent enum value from countDown int
                    Enum.TryParse(countDown.ToString(), out GameCountdown count);

                    // Update countdown text box on form with current countdown state
                    textBoxCountDown.Text = count.ToString();
                    textBoxCountDown.Update();
                }
                while (sw.ElapsedMilliseconds <= DELAY);

                sw.Stop();
                sw.Reset();
            }

            // Clear countdown textbox on form
            textBoxCountDown.Clear();

            // Re-enable Player Choice controls on form (next round)
            groupBoxPlayerChoice.Enabled = true;
        }

        private enum GameCountdown
        {
            GO,
            SET,
            READY
        }

        /// <summary>
        /// Initialise form and start new game
        /// </summary>
        private void StartNewGame()
        {
            const string USER_PROMPT = "Do you wish to start a new game..?";

            // Check if user wishes to start a new game
            if (PromptUserChoice(USER_PROMPT))
            {
                groupBoxPlayerChoice.Enabled = true;
                ClearForm();
                _GameController.StartNewGame();
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        private void ExitGame()
        {
            const string USER_PROMPT = "Do you wish to exit the game..?";

            // Check if user wishes to exit game
            if (PromptUserChoice(USER_PROMPT))
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Opens a Yes / No message box and prompts the user with a choice, returning a boolean (True if Yes, False if No)
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private bool PromptUserChoice(string prompt)
        {
            bool choice = false;

            DialogResult dialogResult = MessageBox.Show(prompt, "Please Choose...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                choice = true;
            }

            return choice;
        }

        #region Events
        /// <summary>
        /// Event: Triggers when player clicks appropriate choice button on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayerSelection_Click(object sender, EventArgs e)
        {
            if (!_GameController.GameOver)
            {
                PlayChoice((sender as Button).Text);
            }
        }

        /// <summary>
        /// Event: Starts a new game when user selects from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        /// <summary>
        /// Event: Starts a new game when user clicks button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        /// <summary>
        /// Event: Exits application when user selects from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        /// <summary>
        /// Event: Exits application when user clicks button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            ExitGame();
        }
        #endregion
    }
}
