using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Helicopter : IAircraft
    {
        ControlTower controlTower_;

        public void TakeoffGranted()
        { }

        public void LandingGranted()
        { }

        public void RequestLanding()
        { }
        public void RequestTakeoff()
        { }

        public Helicopter(ControlTower tower)
        {
            controlTower_ = tower;
        }
    }
}
