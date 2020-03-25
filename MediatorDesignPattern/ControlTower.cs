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
            //Army of GroundPersonnel
            GroundPersonnel.Add(new Technicians()); 
            GroundPersonnel.Add(new Technicians()); 
            GroundPersonnel.Add(new Technicians()); 
            GroundPersonnel.Add(new Technicians());
            GroundPersonnel.Add(new Technicians());
            GroundPersonnel.Add(new BaggageHandlers());
            GroundPersonnel.Add(new BaggageHandlers());
            GroundPersonnel.Add(new BaggageHandlers());
            GroundPersonnel.Add(new BaggageHandlers());
            GroundPersonnel.Add(new BaggageHandlers());
        }

        public void Notify(IAircraft sender, RequestType id)
        {
            if (id == RequestType.Landing)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveLandingRequest();
                    //Console.WriteLine("Personel with ID {0} has received landing request", personel.ID);
                    HandleRequestLanding();
                }
            }

            else if (id == RequestType.TakeOff)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveTakeoffRequest();
                    //Console.WriteLine("Personel with ID {0} has received take off request", personel.ID);
                    HandleRequestTakeoff();
                }
            }
        }

        private void HandleRequestLanding()
        {
            
        }

        private void HandleRequestTakeoff()
        {
            
        }

    }
}
