using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleArena
{
    class Program
    {
        static void Main(string[] args)
        {

            //Flags for fighter selections
            bool fighterChosen = false;

            //Introductory Text            
            Console.WriteLine("Welome to the Arena, where men go to die what for what they live for");
            Console.ReadKey();
            Console.WriteLine("So before you die, what's your story? Who are you anyways?");
            Console.WriteLine();
            Console.WriteLine("Type a number to choose a class");
            Console.WriteLine("1.Swordman");
            /*Console.WriteLine("2.Lancer");
             * Console.WriteLine("3.AxMan");
             * Console.WriteLine("4. Mage");
             * 
             */
            string fighterchoice;
            while (!fighterChosen)
            {
                fighterchoice = Console.ReadLine().ToString();
                
                if (fighterchoice == "1")
                {
                    SwordMan Ryu = new SwordMan();
                    fighterChosen = true;

                }
                else
                {
                    Console.WriteLine("I said a number");

                }
            }
            //Confirmation beep
            Console.Beep();

            SwordMan Jin = new SwordMan();
            Console.WriteLine(Jin.Stats());
            try
            {
                 int level = int.Parse(Console.ReadLine());
                Jin.GenerateFighter(level);
                Console.WriteLine(Jin.Stats());
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error: Non number input");
            }
            

           /* For refrence in console commands
            string[] tokens = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                sum = sum + int.Parse(tokens[i]);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            */
        }
    }
}
