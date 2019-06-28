using System;
using System.Drawing;
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

        private void UpdateForm()
        {
            if (_GameController.GameOver)
            {
                groupBoxPlayerChoice.Enabled = false;
                MessageBox.Show("Game Over", "GAME OVER");
            }
            else
            {
                // Update Game Result text box colour according to result
                switch (_GameController.PlayerStatus)
                {
                    case GameResult.DRAW:
                        textBoxGameResult.ForeColor = Color.AliceBlue;
                        break;
                    case GameResult.LOSE:
                        textBoxGameResult.ForeColor = Color.Red;
                        break;
                    case GameResult.WIN:
                        textBoxGameResult.ForeColor = Color.Green;
                        break;
                }

                // Update Scores
                textBoxPlayerChoice.Update();
                textBoxAIScore.Update();
                textBoxPlayerScore.Update();
                textBoxGameResult.Update();
            }
        }

        private void PlayChoice(string choice)
        {
            textBoxPlayerChoice.Text = choice;
            textBoxAIChoice.Text = _GameController.PlayChoice(choice);
            textBoxAIScore.Text = _GameController.AIScore.ToString();
            textBoxPlayerScore.Text = _GameController.PlayerScore.ToString();
            textBoxGameResult.Text = _GameController.PlayerStatus.ToString();
        }

        /// <summary>
        /// Event: Triggers when player clicks appropriate choice button on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayerSelection_Click(object sender, EventArgs e)
        {
            string choice = (sender as Button).Text;

            if (!_GameController.GameOver)
            {
                PlayChoice(choice);
            }

            UpdateForm();
        }

        /// <summary>
        /// Event: Exits application when user selects from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
        /// Event: Starts a new game when user selects from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxPlayerChoice.Enabled = true;
            ClearForm();
            _GameController.StartNewGame();
        }
    }
}
