using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
                
        }
        public Vehicle(bool areBreaksWorking, float fuelLevel)
        {

        }
        float fuelLevel;
        public abstract bool AreBrakesWorking { get; set; }
        public abstract float FuelLevel { get; set; }

        public bool FixBrakes()
        {
            return true;
        }
        public abstract void RefuelVehicle(float fuelVolume);
    }
}
