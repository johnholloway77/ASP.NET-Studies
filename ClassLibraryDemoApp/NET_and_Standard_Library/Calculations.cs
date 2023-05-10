/*
 Cannot create a library specifically for .NET Standard anymore as it has been phased out as everything becomes .Net
 */

namespace NET_and_Standard_Library
{
    public class Calculations
    {

        public double addition(double x, double y)
        {
            return x + y;
        }

        public double subtraction(double x, double y)
        {
            return x - y;
        }

        public double multiply(double x, double y)
        {
            return x * y;
        }

        public double divide(double x, double y)
        {
            return x / y;
        }

    }
}