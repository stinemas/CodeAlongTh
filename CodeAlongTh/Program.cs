using System;

namespace CodeAlongTh
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(0, 50);

            //car.CheckSpeed();

            var ui = new Ui(car);
        }
    }

    
}
