using System;
using System.Globalization;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, n = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = n * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
