using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);//complete declarando as variáveis
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

            int MAIORABC = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;
            int MAIOR = MAIORABC;

            Console.WriteLine($"{MAIOR} eh o maior");

        }
    }
}
