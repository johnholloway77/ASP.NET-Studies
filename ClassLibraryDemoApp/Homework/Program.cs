/*

Create a .NET Standard class library and a console application.
Put a couple calclation methods in it and call it from the Connsole.

 */


using NET_and_Standard_Library;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 55;
            double y = 75.64;
            Calculations calculations = new Calculations();

            Console.WriteLine($"{x} + {y} = {calculations.addition(x,y)}");
            Console.WriteLine($"{x} - {y} = {calculations.subtraction(x, y)}");
            Console.WriteLine($"{x} * {y} = {calculations.multiply(x, y)}");
            Console.WriteLine($"{x} / {y} = {calculations.divide(x, y)}");

        }
    }
}