using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGameWindow : Form
    {
        GuessGame game;
        NumberLabel[][] grid;

        public GuessingGameWindow()
        {
            InitializeComponent();
            game = new GuessGame(1, 100);
        }

        private void StartGame()
        {
            DrawGrid(13, 13, 32, 32);
            game.ResetGame();
            UpdateControls("startGame");
            MessageBox.Show("Click on number to guess.");
        }

        private void DrawGrid(int x, int y, int width, int height)
        {
            if (grid != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        this.Controls.Remove(grid[i][j]);
                    }
                }
            }
            grid = new NumberLabel[10][];
            for (int i = 0; i < 10; i++)
            {
                grid[i] = new NumberLabel[10];
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i][j] = new NumberLabel();
                    grid[i][j].Text = Convert.ToString(i * 10 + j + 1);
                    grid[i][j].Location = new Point(j * width + x, i * height + y);
                    grid[i][j].Size = new Size(width, height);
                    grid[i][j].TextAlign = ContentAlignment.MiddleCenter;
                    grid[i][j].BorderStyle = BorderStyle.FixedSingle;
                    grid[i][j].numberGuessed += GuessNumber;
                    this.Controls.Add(grid[i][j]);
                }
            }
        }

        private void UpdateControls(string message)
        {
            lblLives.Text = game.GetLivesNumber().ToString();
            lblScore.Text = game.GetScore().ToString();
            try
            {
                txtMessage.Text = game.GetMessage(message);
            }
            catch (ArgumentException)
            {
                txtMessage.Text = message;
            }
        }

        private void DisableNumberLabels()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i][j].Enabled = false;
                }
            }
        }

        private void CheckGameStage(GuessResult guessResult)
        {
            if (guessResult == GuessResult.EQUALS_TO_NUMBER || game.GetLivesNumber() <= 0 || game.GetScore() <= 0)
            {
                string message = guessResult == GuessResult.EQUALS_TO_NUMBER 
                    ? game.GetMessage("PlayAgainMessage")
                    : game.GetMessage("failMessage") + "\n" + game.GetMessage("PlayAgainMessage");
                if (MessageBox.Show(message, "Play again?",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    DisableNumberLabels();
                    UpdateControls(guessResult == GuessResult.EQUALS_TO_NUMBER ? "winMessage" : "failMessage");
                }
            }
        }

        private void GuessNumber(NumberLabel sender, NumberGuessArgs args)
        {
            GuessResult guessResult = this.game.CheckGuess(args.number);
            switch (guessResult)
            {
                case GuessResult.LESS_THAN_NUMBER:
                    UpdateControls("infMessage");
                    sender.BackColor = Color.Yellow;
                    break;
                case GuessResult.GREATER_THAN_NUMBER:
                    UpdateControls("supMessage");
                    sender.BackColor = Color.Red;
                    break;
                case GuessResult.EQUALS_TO_NUMBER:
                    UpdateControls("winMessage");
                    sender.BackColor = Color.Green;
                    break;
                default:
                    throw new ArgumentException();
            }
            CheckGameStage(guessResult);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }

    class NumberGuessArgs : EventArgs
    {
        public int number;
    }

    delegate void NumberGuessedEventHandler(NumberLabel sender, NumberGuessArgs args);

    class NumberLabel : Label
    {
        public event NumberGuessedEventHandler numberGuessed;
        private NumberGuessArgs args;

        public NumberLabel()
        {
            this.Click += new EventHandler(numberLabel_Click);
            args = new NumberGuessArgs();
        }

        private void numberLabel_Click(object sender, EventArgs e)
        {
            args.number = Int32.Parse(this.Text);
            numberGuessed(this, args);
        }
    }
}
