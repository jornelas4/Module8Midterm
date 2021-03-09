using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Silverado : RaceCar
    {
        public Silverado()
        {
            Name = "Silverado";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Name} starts it's engine loudly!!!");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} has stopped completely!!!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The driver in the {Name} has slowed down!!!!");
            base.Brake();
        }



    }
}