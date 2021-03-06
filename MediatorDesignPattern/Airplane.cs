﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Airplane : IAircraft
    {
        private ControlTower controlTower_;

        public void TakeoffGranted()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Airplane: Takeoff has been granted!");
            Console.ResetColor();
        }

        public void LandingGranted()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Airplane: Landing has been granted!");
            Console.ResetColor();
        }

        public void RequestLanding()
        {
            controlTower_.Notify(this, RequestType.Landing);
        }
        public void RequestTakeoff()
        {
            controlTower_.Notify(this, RequestType.TakeOff);
        }

        public Airplane(ControlTower tower)
        {
            controlTower_ = tower;
        }
    }
}
