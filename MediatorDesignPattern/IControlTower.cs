using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IControlTower
    {
        void Notify(IAircraft sender, RequestType id);
    }
}
