using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class Technicians : GroundPersonnel
    {
        public Technicians(int id)
        {
            EmployeeID = id;
        }

        public override void ReceiveLandingRequest()
        {
            Console.WriteLine("Technician with ID {0} has received take off request", EmployeeID);
        }

        public override void ReceiveTakeoffRequest()
        {
            Console.WriteLine("Technician with ID {0} has received take off request", EmployeeID);
        }
    }
}
