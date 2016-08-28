using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExtention
{
    public class Vehicle
    {
        public int Velocity { get; set; }
        public int Acceleration { get; set; }
        public int MaxVelocity { get; set; }
        public int Heading { get; set; }
        public void Start()
        {

        }
    }
    public static class VehicleExtension
    {
        public static void TurnOff( this Vehicle v)
        {
        }
    }
}
