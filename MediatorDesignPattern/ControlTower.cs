using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ControlTower
    {
        private List<IAircraft> TakeoffQueue;
        private List<IAircraft> LandingQueue;
        private List<IAircraft> Aircrafts;
        private List<GroundPersonnel> GroundPersonnel;

        public void Notify()
        { }

        public void HandleRequest()
        { }


    }
}
