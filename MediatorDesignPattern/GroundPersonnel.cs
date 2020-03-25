using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public abstract class GroundPersonnel
    {
        protected int EmployeeID;
        public ICommunication commDevice;

        public abstract void ReceiveCommunication(RequestType id);

        public abstract void ReceiveLandingRequest();

        public abstract void ReceiveTakeoffRequest();
    }
}
