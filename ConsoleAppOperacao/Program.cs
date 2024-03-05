using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int pnu = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int snu = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: (*, /, +, -) ");
            string ope = Console.ReadLine();

            if (ope == "+")
            {
                int result = pnu + snu;
                Console.WriteLine("O resultado é: " + result);
            } else if (ope == "-")
            {
                int result = pnu - snu;
                Console.WriteLine("O resultado é: " + result);
            } else if (ope == "*")
            {
                int result = pnu * snu;
                Console.WriteLine("O resultado é: " + result);
            } else if (ope == "/")
            {
                int result = pnu / snu;
                Console.WriteLine("O resultado é: " + result);
            } else if (ope != "*, /, +, -")
            {
                Console.WriteLine("A operação não pode ser efetuada");
            }

            Console.ReadKey();
        }
    }
}
