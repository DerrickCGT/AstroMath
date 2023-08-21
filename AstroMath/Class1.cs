using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstronomicalCalculation
    {

        const double speedOfLight = 299792458;      // Gravitational constant in m^3 kg^-1 s^-2
        const double gravityConstant = 6.674e-11;   // Speed of light in m/s
        const double massOfSun = 2e30;              // Mass of the sun in kg

        public static double CalculateStarVelocity(double observedWavelength, double restWavelength)
        {

            var changeWavelength = observedWavelength - restWavelength;
            
            return speedOfLight * (changeWavelength / restWavelength);

        }


        public static double CalculateEventHorizon(double blackholeMass)
        {
           
            double schwarzschildRadius = (2 * gravityConstant * blackholeMass) / (speedOfLight * speedOfLight);

            return schwarzschildRadius;
        }


    }
  
}
