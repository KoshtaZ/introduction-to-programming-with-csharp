using System;
using System.Globalization;


namespace Triangle
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            
            x = new Triangle();
            y = new Triangle();
            
            Console.WriteLine("Enter X coordinate: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            
            Console.WriteLine("Enter Y coordinate: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area();
            
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY){
                Console.WriteLine("Maior area: X");
            }
            else
                Console.WriteLine("Maior area: Y");
                

        }
    }
}

