using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface ICommunication
    {
        void receive(GroundPersonnel sender, RequestType id);
    }
}
