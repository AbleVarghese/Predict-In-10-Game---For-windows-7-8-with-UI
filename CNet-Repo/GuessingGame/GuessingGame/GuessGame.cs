using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GuessGame
    {
        private Dictionary<string, string> GGString;
        private Dictionary<string, int> GGInt;
        private Random random;

        private int numberToGuess;
        private int fromNumber;
        private int toNumber;

        public GuessGame(int fromNumber, int toNumber)
        {
            GGString = new Dictionary<string, string>();
            GGInt = new Dictionary<string, int>();
            random = new Random();
            this.fromNumber = fromNumber;
            this.toNumber = toNumber;
            InitializeMessageDic();
            ResetGame();
        }

        public string GetMessage(string messageType)
        {
            if (!GGString.ContainsKey(messageType))
            {
                throw new ArgumentException();
            }
            return GGString[messageType];
        }

        public int GetScore()
        {
            return GGInt["score"];
        }

        public int GetLivesNumber()
        {
            return GGInt["lives"];
        }

        private void InitializeMessageDic()
        {
            this.GGString.Clear();
            this.GGString.Add("startGame", "Start the Game");
            this.GGString.Add("failMessage", "sorry game over");
            this.GGString.Add("winMessage", "CONGRATULATIONS YOU WON THE GAME");
            this.GGString.Add("infMessage", "Number provided is less than the number picked by the program,... Please try again!.");
            this.GGString.Add("supMessage", "Number provided is greater than the number picked by the program,... Please try again!.");
            this.GGString.Add("PlayAgainMessage", "Would you like to play again? Y/N.");
        }

        public void ResetGame()
        {
            this.GGInt.Clear();
            this.GGInt.Add("score", 100);
            this.GGInt.Add("lives", 10);
            this.numberToGuess = this.random.Next(this.fromNumber, this.toNumber);
        }

        public GuessResult CheckGuess(int userGuess)
        {
            if (GGInt["lives"] <= 0 || GGInt["score"] <= 0)
            {
                throw new ApplicationException();
            }

            GuessResult result;
            if (userGuess < numberToGuess)
            {
                GGInt["score"] -= 10;
                GGInt["lives"] -= 1;
                result = GuessResult.LESS_THAN_NUMBER;
            }
            else if (userGuess > numberToGuess)
            {
                GGInt["score"] -= 10;
                GGInt["lives"] -= 1;
                result = GuessResult.GREATER_THAN_NUMBER;
            }
            else
            {
                result = GuessResult.EQUALS_TO_NUMBER;
            }
            return result;
        }

        public bool HasMoreLives()
        {
            return GGInt["lives"] > 0;
        }
    }
    enum GuessResult
    {
        LESS_THAN_NUMBER, GREATER_THAN_NUMBER, EQUALS_TO_NUMBER
    }
}
