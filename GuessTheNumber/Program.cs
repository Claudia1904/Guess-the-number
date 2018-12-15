using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {

        public static void GuessNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int yourNumber = 0;
            
            while(yourNumber != number)
            {
                Console.WriteLine("Please enter a number between 1 and 100: ");
                yourNumber = int.Parse(Console.ReadLine());

                if (yourNumber < number)
                {
                    Console.WriteLine("The number {0} is too low.", yourNumber);
                }
                else if (yourNumber > number)
                {
                    Console.WriteLine("The number {0} is too high.", yourNumber);
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                }
            } 
        }

        static void Main(string[] args)
        {
            GuessNumber();
        }
    }
}
