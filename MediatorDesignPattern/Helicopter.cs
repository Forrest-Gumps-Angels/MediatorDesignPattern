using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Helicopter : IAircraft
    {
        ControlTower controlTower_;

        public void TakeoffGranted()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Helicopter: Takeoff has been granted!");
            Console.ResetColor();
        }

        public void LandingGranted()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Helicopter: Landing has been granted!");
            Console.ResetColor();
        }

        public void RequestLanding()
        {
            controlTower_.notify(this, RequestType.Landing);
        }
        public void RequestTakeoff()
        {
            controlTower_.notify(this, RequestType.TakeOff);
        }

        public Helicopter(ControlTower tower)
        {
            controlTower_ = tower;
        }
    }
}
