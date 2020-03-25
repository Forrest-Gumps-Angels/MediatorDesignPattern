using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ControlTower : IControlTower
    {
        private List<GroundPersonnel> GroundPersonnel = new List<GroundPersonnel>();

        public ControlTower()
        {

            for (int i = 0; i > 5; i += 2)
            {
                GroundPersonnel.Add(new Technicians(i));
                GroundPersonnel.Add(new BaggageHandlers(i+1));
            }
        }

        public void Notify(IAircraft sender, RequestType id)
        {
            if (id == RequestType.Landing)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveLandingRequest();
                    HandleRequestLanding(sender);
                }
            }

            else if (id == RequestType.TakeOff)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveTakeoffRequest();
                    HandleRequestTakeoff(sender);
                }
            }
        }

        private void HandleRequestLanding(IAircraft sender)
        {
            sender.LandingGranted();
            Console.WriteLine("Landing granted for {0}", sender);
        }

        private void HandleRequestTakeoff(IAircraft sender)
        {
            sender.TakeoffGranted();
            Console.WriteLine("Take off granted for {0}", sender);
        }

    }
}
