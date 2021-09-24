using System;

namespace TipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int tipo = 0;
            int combustivel;

            do
            {
                tipo = Convert.ToInt32(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        combustivel = alcool += 1;
                        break;

                    case 2:
                        combustivel = gasolina += 1;
                        break;


                    case 3:
                        combustivel = diesel += 1;
                        break;

                    case 4:
                        break;
                    default:
                        continue;

                }


            } while (tipo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
