using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ControlTower
    {
        private Queue<IAircraft> TakeoffQueue;
        private Queue<IAircraft> LandingQueue;
        private List<GroundPersonnel> GroundPersonnel;

        public void NotifyTakeoff()
        { }

        public void NotifyLanding()
        { }

        public void HandleRequestLanding()
        { }

        public void HandleRequestTakeoff()
        { }

    }
}
