using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public class FourWheeler : Vehicle
    {
        public char engineCoolentLevel;
        public char EngineCoolentLevel { get; set; }
        public override bool AreBrakesWorking { get; set; }
        public override float FuelLevel { get; set; }

        public FourWheeler()
        {

        }
        public FourWheeler(bool areBrakesWorking, float fuelLevel, char engineCoolantLevel)
        {
            this.FuelLevel = fuelLevel;
            this.AreBrakesWorking = areBrakesWorking;
            this.EngineCoolentLevel = engineCoolantLevel;
        }

        public bool FixEngineCoolentLevel()
        {
            if (this.EngineCoolentLevel != 'H')
            {
                this.EngineCoolentLevel = 'H';
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void RefuelVehicle(float fuelVolume)
        {
            if(this.FuelLevel+fuelVolume>50)
            {
                FuelOverflowException.FuelException();
            }
            else
            {
                this.FuelLevel = this.FuelLevel + fuelVolume;
            }
        }
    }
}
