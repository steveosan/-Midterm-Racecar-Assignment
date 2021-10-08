using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Tesla : RaceCar
    { 
        public Tesla()
        {
            Name = "Tesla";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} battery makes a zap!");
        }
    }
}