using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles._Interfaces
{
    public interface ISwimmer : IVehicles
    {
        // a double property called MaxWaterSpeed
        double MaxWaterSpeed { get; }

        // a method called Drive() that returns void
        void Drive();
    }
}
