using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Technicians : GroundPersonnel
    {
        Technicians(int id)
        {
            EmployeeID = id;
        }

        public override void ReceiveLandingRequest()
        {
            Console.WriteLine("Technicians receives landing request and prepares for airplane");
        }

        public override void ReceiveTakeoffRequest()
        {
            Console.WriteLine("Technicians receives takeoff request and prepares airplane for takeoff");
        }
    }
}
