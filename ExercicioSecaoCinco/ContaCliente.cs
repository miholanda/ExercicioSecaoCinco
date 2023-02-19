using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioSecaoCinco
{
    class ContaCliente
    {
        //Numero da conta nao pode ser modificado depois da criação
        private int _numeroConta;

        public string NomeCliente;

        //DepositoInicial sem necessidade de validações. S/N
        public bool DepositoInicial { get; set; }

        public double ValorDepositoInicial;

        //saldo da conta modificado apenas por metodos
        private double _saldoConta { get; set; }

        //construtor padrao
        public ContaCliente()
        {
        }

        public ContaCliente(int numero, string nome, double saldo)
        {
            this._numeroConta = numero;
            NomeCliente = nome;
            saldo = _saldoConta;
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if (value != null && value > 0)
                {
                    _numeroConta = value;
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
        }

        public double ChecaSeDepositoInicial(char opcao)
        {
            _saldoConta = 0.0;
            if (opcao == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double valorInicial;
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ValorDepositoInicial = valorInicial;
                _saldoConta = valorInicial;
            }
            if (opcao == 'n')
            {
                ValorDepositoInicial = 0;
            }
            if (opcao != 's' && opcao != 'n')
            {
                Console.WriteLine("Invalido.");
            }

            return _saldoConta;
        }

        public double AdicionarFundos(double ValorAdicionar)
        {
            _saldoConta += ValorAdicionar;
            Console.WriteLine("Dados da conta atualizados: ");
            return _saldoConta;
        }

        public double RetirarFundos(double ValorSaque)
        {
            _saldoConta -= (ValorSaque + 5.00);
            Console.WriteLine("Dados da conta atualizados: ");
            return _saldoConta;
        }

        public override string ToString()
        {
            return "Conta "
                + _numeroConta
                + ", "
                + "Titular: "
                + NomeCliente
                + ", "
                + "Saldo: $ "
                + _saldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
