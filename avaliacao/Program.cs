using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto vai ser depositado? ");
            double deposito = double.Parse(Console.ReadLine());
           
            while (deposito > 0)
            {
                Console.WriteLine("Quanto vai ser sacado?");
                double saque = double.Parse(Console.ReadLine());
                Console.WriteLine("Quanto será o pagamento: ");
                double pag = double.Parse(Console.ReadLine());
                double saldo = deposito - saque - pag;
                Console.WriteLine("Quer consultar seu saldo?");
                string respostaletra = Console.ReadLine().ToUpper();

                if (respostaletra == "Sim ou s");
                {
                    Console.WriteLine("O saldo é: ", saldo);

                }
                else {
                    Console.WriteLine("Erro");
                }

                             
                switch (deposito)
                {
                    case saque:
                        double resultado1 = deposito - saque;
                        Console.WriteLine("Você sacou" + resultado1);
                        break;
                    case pag:
                        double resultado2 = deposito - pag;
                        Console.WriteLine("Você pagou" + resultado2);
                        break;
                    case saldo:
                        double resultado3 = deposito - pag - saque;
                        break;
                    default:
                        Console.WriteLine("ERRO");
                        break;
                }
            }
        }
    }
}
