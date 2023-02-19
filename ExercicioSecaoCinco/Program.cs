using System;
using System.Globalization;

namespace ExercicioSecaoCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCliente cliente = new ContaCliente();


            Console.Write("Entre o numero da conta: ");
            cliente.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular da conta: ");
            cliente.NomeCliente = Console.ReadLine();

            Console.Write("Você vai fazer um deposito inicial? (s/n) ");
            char op = char.Parse(Console.ReadLine());
            cliente.ChecaSeDepositoInicial(op);

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double ValorAdicionar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.AdicionarFundos(ValorAdicionar);

            Console.WriteLine(cliente);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.RetirarFundos(ValorSaque);

            Console.WriteLine(cliente);
        }
    }
}