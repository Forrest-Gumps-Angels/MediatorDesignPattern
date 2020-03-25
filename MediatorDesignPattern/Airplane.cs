using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Airplane : IAircraft
    {
        private int ID;
        private ControlTower controlTower_;

        public void TakeoffGranted()
        { }

        public void LandingGranted()
        { }

        public void RequestLanding()
        { }

        public void RequestTakeoff()
        { }
    }
}
