using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace wisielec
{
    public class Game
    {
        public void run()
        {
            var provider = new Provider();
            var word = new Word();
            string choice;

            do
            {
                Console.Clear();
                Write("You have 10 tries");
                word.Checking();
                Write("\nDo you want to play again? (y/n)\n");
                choice = ReadLine();
            } while (choice == "y");
        }

        public string guess()
        {
            Write("\nGuess letter\n");
            return ReadLine();
        }
    }
}