using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Airplane : IAircraft
    {
        private int ID;

        public void TakeoffGranted()
        { }

        public void LandingGranted()
        { }

        private void SendPosition()
        { }

        private void RequestLanding()
        { }

        private void RequestTakeoff()
        { }
    }
}
