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
            Console.WriteLine("BagageHandlers receives landing request and pack airplane bagage");
        }

        public override void ReceiveTakeoffRequest()
        {
            Console.WriteLine("BagageHandlers receives takeoff request and prepares to unpack airplane bagage");
        }
    }
}
