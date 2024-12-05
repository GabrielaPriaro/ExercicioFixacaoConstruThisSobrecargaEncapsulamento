using System;
using System.Globalization;

namespace ExercicioFixacaoConstruThisSobrecargaEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorDeposito = 0;

            ContaBancaria conta;

            Console.Write("Numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            bool isDepositoInicial = StringToBool(Console.ReadLine());

            if (isDepositoInicial)
            {
                Console.Write("Digite o valor do deposito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeTitular, valorDeposito);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nValor para deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nValor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }

        static bool StringToBool(string valor)
        {
            if (valor.ToUpper() == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
