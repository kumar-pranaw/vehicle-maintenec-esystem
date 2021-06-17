using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public class TwoWheeler : Vehicle
    {

        public TwoWheeler()
        {

        }
        public TwoWheeler(bool areBrakesWorking,float fuelLevel)
        {

        }

        public override bool AreBrakesWorking { get; set; }
        public override float FuelLevel { get ; set ; }

        public override void RefuelVehicle(float fuelVolume)
        {
            throw new NotImplementedException();
        }
    }
}
