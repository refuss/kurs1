using System;
using System.Globalization;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to The Game...");
            Console.WriteLine("Please choose what do you want to do:");
            Console.WriteLine("1. Create a character");
            Console.WriteLine("2. Choose a character");
            Console.WriteLine("3. Delete a character");
            Console.WriteLine("4. Logout");

            string choice = Console.ReadLine();

            Console.WriteLine($"You've chosen number: {choice}");

            int chosenOpt = 0;
            Int32.TryParse(choice, out chosenOpt);
            Console.WriteLine("Please choose another option...");
            choice = Console.ReadLine();
            Int32.TryParse(choice, out chosenOpt);

            if(chosenOpt == 1)
            {
                //operacje związane z daną opcją. Tworzymy poprzez dodanie obiektu dla danej rzeczy

            }


            Console.ReadKey();
        }
    }
}
