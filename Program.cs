using System;
using SolidVehicles.Air_Based;
using SolidVehicles.Land_Based;
using SolidVehicles.Water_Based;
using SolidVehicles._Interfaces;
using System.Collections.Generic;

namespace SolidVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cessna = new Cessna();
            var ufo = new UFO();

            var delorean = new DeLorean();
            var ducati = new Ducati();

            var jetski = new JetSki();
            var tugboat = new Tugboat();


            // Build a collection of all vehicles that fly
            var flyingStuff = new List<IFly> { cessna, ufo };

            // With a single `foreach`, have each vehicle Fly()
            foreach (var vehicle in flyingStuff)
            {
                vehicle.Fly();
            }


            // Build a collection of all vehicles that operate on roads
            var roadRunners = new List<IDriver> { delorean, ducati };

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var roadHog in roadRunners)
            {
                roadHog.Drive();
            }


            // Build a collection of all vehicles that operate on water
            var waveracers = new List<ISwimmer> { jetski, tugboat };

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var boat in waveracers)
            {
                boat.Drive();
            }
        }
    }
}
