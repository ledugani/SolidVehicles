﻿using SolidVehicles._Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Land_Based
{
    public class DeLorean : IDriver
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; } = 160.4;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The 750 SS screams down the highway");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
