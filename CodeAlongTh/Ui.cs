using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongTh
{
    public class Ui
    {
        public Ui(Car car)
        {
            bool run = true;

            while (run)
            {


                int parsedInput;

                // Prompt.
                Console.Write("Change speed by: ");
                
                // Get user input.
                string input = Console.ReadLine();
                
                // Try to parse input, if valid (int), do stuff.
                if (int.TryParse(input, out parsedInput))
                {
                    car.ChangeSpeed(parsedInput);
                    Console.WriteLine();
                }
                else if (input.ToLower() == "quit") run = false; // End the loop, if input is the string "quit".
                else // Input is invalid, say so.
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                }

                // check current speed before taking new user input.
                car.CheckSpeed();
                Console.WriteLine();
                
                // Loop body ends, loop starts again from top.
            }
        }
    }
}
