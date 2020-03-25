using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Headset : ICommunication
    {
        public void receive()
        {
            Console.WriteLine("Received request on Headset");
        }
    }
}
