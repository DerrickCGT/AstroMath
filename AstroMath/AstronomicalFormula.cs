using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Derrick Choong
/// ID: 30066568
/// Dynamic Link Library .DLL file contain Astronomical Calculation Formula
/// </summary>

namespace AstroMath
{
    /// <summary>
    /// Class AstronomicalForumla for performing various astronomical calculations.
    /// </summary>
    public class AstronomicalFormula
    {

        const double speedOfLight = 299792458.0;    // Speed of light in m/s
        const double gravityConstant = 6.674e-11;   // Gravitational constant in m^3 kg^-1 s^-2

        /// <summary>
        /// This method calculates the star velocity using Doppler Shift.
        /// </summary>
        /// <param name="observedWavelength">Observed wavelength of the star.</param>
        /// <param name="restWavelength">Rest wavelength of the star.</param>k
        /// <returns>Calculated star velocity in meters per second.</returns>
        public static double StarVelocity(double observedWavelength, double restWavelength)
        {

            double changeWavelength = observedWavelength - restWavelength;
            double velocity = speedOfLight * (changeWavelength / restWavelength);
            return Math.Round(velocity, 2);
        }

        /// <summary>
        /// This method calculates the star distance using the parallax angle.
        /// </summary>
        /// <param name="arsecondsAngle">Parallax angle in archseconds.</param>
        /// <returns>Calculated star distance in parsecs (1 parsec = 3.0857E16 meters).</returns>
        public static double StarDistance(double arcSecondsAngle)
        {
             return Math.Round(1 / arcSecondsAngle, 2);
        }

        /// <summary>
        /// This method calculate temperature in Kelvin based on Celsius.
        /// </summary>
        /// <param name="celcius">Temperature in Celsius.</param>
        /// <returns>Calculated temperature in degree Kelvin.</returns>
        public static double TemperatureInKelvin(double celcius)
        {
            return celcius + 273;
        }

        /// <summary>
        /// This method calculate event horizon (Schwarzschild radius) of a black hole.
        /// </summary>
        /// <param name="blackholeMass">Mass of the black hole in kilograms.</param>
        /// <returns>Calculated event horizon (Schwarzschild radius) in meters.</returns>
        public static double EventHorizon(double blackholeMass)
        {
            double schwarzschildRadius = (2.0 * gravityConstant * blackholeMass) / Math.Pow(speedOfLight, 2);
            return schwarzschildRadius;
        }

    }

}
