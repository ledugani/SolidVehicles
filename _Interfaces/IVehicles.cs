using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles._Interfaces
{
    public interface IVehicles
    {
        // an int property called Wheels
        int Wheels { get; }

        // an int property called Doors
        int Doors { get; }

        // an int property called PassengerCapacity
        int PassengerCapacity { get; }
        
        // a string property called TransmissionType
        string TransmissionType { get; }

        // a double property called EngineVolume
        double EngineVolume { get; }

        // a method called Start() that returns void
        void Start();

        // a method called Stop() that returns void
        void Stop();
    }
}
