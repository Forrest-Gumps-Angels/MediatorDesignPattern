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

        public void RequestLanding()
        { }
        public void RequestTakeoff()
        { }
    }
}
