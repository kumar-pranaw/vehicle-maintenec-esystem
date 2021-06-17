using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public static class FuelOverflowException
    {
        public static void FuelException()
        {
            try
            {
                throw new OverflowException();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
