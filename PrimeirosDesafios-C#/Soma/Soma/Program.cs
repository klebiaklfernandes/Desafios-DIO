using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando as variáveis
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            //Inserindo as variáveis
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
        }
    }
}
