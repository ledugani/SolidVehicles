using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles._Interfaces
{
    public interface IDriver : IVehicles
    {
        // a double property called MaxLandSpeed
        double MaxLandSpeed { get; }

        // a method called Drive() that returns void
        void Drive();
    }
}
