using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles._Interfaces
{
    public interface IFly : IVehicles
    {
        // a bool property called Winged
        bool Winged { get; }

        // a double property called MaxAirSpeed
        double MaxAirSpeed { get; }
        
        // a method called Fly() that returns void
        void Fly();
    }
}
