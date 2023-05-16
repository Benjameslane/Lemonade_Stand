using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        //Member Variables (Has A)
        private Player player;
        private List<Day> Days;
        private int currentDay;

        //Constructor
        public Game()
        {

        }

        //Member Methods (Can Do)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("You will have seven days to make as much money as you can.");
            Console.WriteLine("The Weather and your pricing both affect your success.");
            Console.WriteLine("How much money can you make?!");
        }
        public void RunGame()
        //StepOne: Display the rules of the game
        //StepTwo: Ask how many human players will be playing
        {
            WelcomeMessage();

        }
    }
}
