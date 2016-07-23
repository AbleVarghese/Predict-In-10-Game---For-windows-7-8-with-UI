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
    public partial class Form1 : Form
    {
        public Form1()
        {
           // InitializeComponent();
            MessageAssignment();
            startGame();
        }


        private int randomVar;
        private Dictionary<String, String> GGString = new Dictionary<string, string>();
        private Dictionary<String, int> GGInt = new Dictionary<string, int>();
        private Random random = new Random();
        int pickNumber;
       

        void MessageAssignment() { 

        this.GGString.Add("startGame", "start the game");
        this.GGString.Add("failMessage", "sorry game over");
        this.GGString.Add("winMessage", "CONGRATULATIONS YOU WON THE GAME");
        this.GGString.Add("infMessage", "Number provided is less than the number picked by the program,... Please try again!.");
        this.GGString.Add("supMessage", "Number provided is greater than the number picked by the program,... Please try again!.");
        this.GGString.Add("PlayAgainMessage", "Would you like to play again? Y/N.");

        this.GGInt.Add("score", 100);
        this.GGInt.Add("lives", 10);

    }

        void startGame()
        {
           this.randomVar =  this.random.Next(1, 100);
           Console.WriteLine("random number is {0}",randomVar);
           this.pickNumber= Convert.ToInt32(Console.ReadLine());

         
           if (pickNumber<randomVar)
           { 

           
           }
           else if (pickNumber > randomVar)
           {


           }

           else if (pickNumber == randomVar)
           {


           }

           else
           {
               Console.WriteLine("Wrong Input");
           }



        }
        




    }
}
