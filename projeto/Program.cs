using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax² + bx + c = 0
            // d = b² - 4ac
            // x = -b +- sqrt(d)/2a

            Console.WriteLine("Raízes da Equação de Segundo Grau");

            Console.WriteLine("");

            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Equações de segundo grau não podem ter a = 0");
            }
            else 
            {
                double d = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                if (d > 0)
                    Console.WriteLine($"Os valores das raízes são: {x1}, {x2} ");
                else if (d < 0)
                    Console.WriteLine("Essa equação não possui raízes reais");
                else if (d == 0)
                {
                    x1 = x2;
                    Console.WriteLine($"Essa equação possui apenas uma raíz, que é: {x1}");
                }
            }
            
            //tá muito bom, parabéns!!!
        }
    }
}
