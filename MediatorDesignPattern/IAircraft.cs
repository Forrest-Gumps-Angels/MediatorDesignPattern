using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IAircraft
    {
        void TakeoffGranted();
        void LandingGranted();
        void RequestLanding();
        void RequestTakeoff();



    }
}
