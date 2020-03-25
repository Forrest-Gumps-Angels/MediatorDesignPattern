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
            GroundPersonnel.Add(new Technicians());     //Mark
            GroundPersonnel.Add(new Technicians());     //Cindy
            GroundPersonnel.Add(new Technicians());     //Crystal
            GroundPersonnel.Add(new Technicians());     //Dick
            GroundPersonnel.Add(new Technicians());     //Sean
            GroundPersonnel.Add(new BaggageHandlers()); //Ken
            GroundPersonnel.Add(new BaggageHandlers()); //Natasha
            GroundPersonnel.Add(new BaggageHandlers()); //Adriana
            GroundPersonnel.Add(new BaggageHandlers()); //Brandi
            GroundPersonnel.Add(new BaggageHandlers()); //Alex
        }

        public void Notify(IAircraft sender, RequestType id)
        {
            if (id == RequestType.Landing)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveLandingRequest();
                    //Console.WriteLine("Personel with ID {0} has received landing request", personel.ID);
                    HandleRequestLanding(sender);
                }
            }

            else if (id == RequestType.TakeOff)
            {
                foreach (var personel in GroundPersonnel)
                {
                    personel.ReceiveTakeoffRequest();
                    //Console.WriteLine("Personel with ID {0} has received take off request", personel.ID);
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
