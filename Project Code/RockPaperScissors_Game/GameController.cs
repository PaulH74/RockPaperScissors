using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    class GameController
    {
        #region Private Attributes and Public Read-only Properties
        private Random _RandomNumber;

        private bool _GameOver;
        public bool GameOver
        {
            get { return _GameOver; }
        }

        private int _PlayerScore;
        public int PlayerScore
        {
            get { return _PlayerScore; }
        }
        
        private int _AIScore;
        public int AIScore
        {
            get { return _AIScore; }
        }

        private GameResult _PlayerStatus;
        public GameResult PlayerStatus
        {
            get { return _PlayerStatus; }
        }

        #endregion

        // Custom Constructor
        public GameController()
        {
            StartNewGame();
        }

        #region Methods
        /// <summary>
        /// Resets game parameters
        /// </summary>
        public void StartNewGame()
        {
            // Rest flag
            _GameOver = false;

            // Reset scores
            _PlayerScore = 0;
            _AIScore = 0;

            // Instance a random number object
            _RandomNumber = new Random();
        }

        /// <summary>
        /// Gets a random integer value to determine AI choice
        /// </summary>
        /// <returns></returns>
        private int GetAIChoice()
        {
            const int MAX_VALUE = 3;        // N - 1 selected in .Next()
            const int MIN_VALUE = 0;

            return _RandomNumber.Next(MIN_VALUE, MAX_VALUE);
        }

        /// <summary>
        /// Plays player choice and random AI choice to determine winner, updating scores accordingly
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public string PlayChoice(string choice)
        {
            // Parse string into GameChoice enum for player
            Enum.TryParse<GameChoice>(choice, out GameChoice playerChoice);

            // Get random choice for AI
            GameChoice AIChoice = (GameChoice)GetAIChoice();

            // Play game
            GetResult(playerChoice, AIChoice);
            UpdateScores();

            return AIChoice.ToString();
        }

        /// <summary>
        /// Compares player and AI choices and determines if player wins, loses or draws
        /// </summary>
        /// <param name="playerChoice"></param>
        /// <param name="AIChoice"></param>
        private void GetResult(GameChoice playerChoice, GameChoice AIChoice)
        {
            // Check if draw
            if (playerChoice == AIChoice)
            {
                // Game is draw
                _PlayerStatus = GameResult.DRAW;
            }
            else
            {
                // Find winner
                switch (playerChoice)
                {
                    case GameChoice.ROCK:
                        switch (AIChoice)
                        {
                            case GameChoice.PAPER:
                                // Player loses
                                _PlayerStatus = GameResult.LOSE;
                                break;
                            case GameChoice.SCISSORS:
                                // Player wins
                                _PlayerStatus = GameResult.WIN;
                                break;
                        }
                        break;
                    case GameChoice.PAPER:
                        switch (AIChoice)
                        {
                            case GameChoice.ROCK:
                                // Player wins
                                _PlayerStatus = GameResult.WIN;
                                break;
                            case GameChoice.SCISSORS:
                                // Player loses
                                _PlayerStatus = GameResult.LOSE;
                                break;
                        }
                        break;
                    case GameChoice.SCISSORS:
                        switch (AIChoice)
                        {
                            case GameChoice.ROCK:
                                // Player loses
                                _PlayerStatus = GameResult.LOSE;
                                break;
                            case GameChoice.PAPER:
                                // Player wins
                                _PlayerStatus = GameResult.WIN;
                                break;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Update game scores according to game result
        /// </summary>
        /// <param name="gameResult"></param>
        private void UpdateScores()
        {
            const int MAX_SCORE = 3;

            switch (_PlayerStatus)
            {
                case GameResult.LOSE:
                    _AIScore++;
                    break;
                case GameResult.WIN:
                    _PlayerScore++;
                    break;
            }

            if (_AIScore == MAX_SCORE || _PlayerScore == MAX_SCORE)
            {
                _GameOver = true;
            }
        }

        #endregion
    }
}
