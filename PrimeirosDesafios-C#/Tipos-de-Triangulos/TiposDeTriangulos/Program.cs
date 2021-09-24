using System;
using System.Linq;

namespace TiposDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            double[] sortNumbers = { double.Parse(s[0]), double.Parse(s[1]), double.Parse(s[2]) };

            double[] sortedList = sortNumbers.OrderByDescending(x => x).ToArray();

            double a = sortedList[0];
            double b = sortedList[1];
            double c = sortedList[2];

            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            
            if (a >= (b + c))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a2 == (b2 + c2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a2 > (b2 + c2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a2 < (b2 + c2))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && b != c) || (b == c && a != c) || (a == c && b != c))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
