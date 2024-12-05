using System.Globalization;

namespace ExercicioFixacaoConstruThisSobrecargaEncapsulamento
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double ValorDeposito { get; private set; }

        public ContaBancaria(int numero, string nomeTitular, double valorDeposito)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
            ValorDeposito = valorDeposito;
        }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            NomeTitular = nome;
        }

        public void Depositar(double valor)
        {
            ValorDeposito = ValorDeposito + valor;
        }

        public void Sacar(double valor)
        {
            ValorDeposito = ValorDeposito - valor - 5.00;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {NomeTitular}, Saldo: $ {ValorDeposito.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
