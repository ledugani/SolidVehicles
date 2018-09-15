using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles._Interfaces
{
    interface ISwimmer
    {
        // a double property called MaxWaterSpeed
        double MaxWaterSpeed { get; }

        // a method called Drive() that returns void
        void Drive();
    }
}
