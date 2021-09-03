using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongTh
{
    public class Car
    {
        public int Speed;
        public int Limit;

        public Car(int speed, int limit)
        {
            Speed = speed;
            Limit = limit;

            Console.WriteLine($"Spawned new car with speed {Speed} km/h (limit: {Limit} km/h).");
        }

        public void CheckSpeed()
        {
            if (Speed <= Limit && Speed >= invertInt(Limit))
            {
                Console.Write("Keep driving, you're doing great.");

            }
            else
            {
                Console.Write($"Slow down, you're going {Speed} km/h, but the Speedlimit is {Limit} km/h");
            }
        }

        public void ChangeSpeed(int speedChange)
        {
            Speed += speedChange;
        }

        public int invertInt (int i)
        {
            // 50 - 50 - 50 = -50
            return i  -  i  -  i;
        }

    }
}
