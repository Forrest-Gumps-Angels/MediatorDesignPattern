using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Headset : ICommunication
    {
        public void receive(GroundPersonnel sender, RequestType id)
        {
            Console.WriteLine("Received request on Headset");

            switch(id)
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
