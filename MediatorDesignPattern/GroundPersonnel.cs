using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public abstract class GroundPersonnel
    {
        private int EmployeeID;

        public void ReceiveCommunication()
        { }

        public abstract void ReceiveLandingRequest();

        public abstract void ReceiveTakeoffRequest();
    }
}
