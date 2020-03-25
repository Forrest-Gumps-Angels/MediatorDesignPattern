using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Helicopter : IAircraft
    {
        public void TakeoffGranted()
        { }

        public void LandingGranted()
        { }

        void RequestLanding()
        { }
        void RequestTakeoff()
        { }
    }
}
