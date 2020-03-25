using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class WalkeyTalky : ICommunication
    {
        public void receive()
        {
            Console.WriteLine("Received request on Walkey Talky");
        }
    }
}
