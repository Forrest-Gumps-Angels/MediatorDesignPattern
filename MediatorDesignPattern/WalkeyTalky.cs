using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class WalkeyTalky : ICommunication
    {
        public void receive(GroundPersonnel sender, RequestType id)
        {
            Console.WriteLine("Received request on Walkey Talky");

            switch (id)
            {
                case RequestType.Landing:
                    sender.ReceiveLandingRequest();
                    break;
                case RequestType.TakeOff:
                    sender.ReceiveTakeoffRequest();
                    break;
            }
        }
    }
}
