using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class BaggageHandlers : GroundPersonnel
    {
        BaggageHandlers(int id)
        {
            EmployeeID = id;
        }

        public override void ReceiveLandingRequest()
        {
            Console.WriteLine("BagageHandler with ID {0} has received landing request", EmployeeID);
        }

        public override void ReceiveTakeoffRequest()
        {
            Console.WriteLine("BagageHandler with ID {0} has received take off request", EmployeeID);
        }
    }
}
