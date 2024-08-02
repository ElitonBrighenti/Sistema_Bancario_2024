using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    public class ContaBancaria
    {
        public int Numero {  get; set; }
        public string Dono { get; set; }
        private double saldo;

        public ContaBancaria(int numero, string dono)
        {
            Numero = numero;
            Dono = dono;
        }
        public void Sacar(double valor)
        {
            if (valor > 0)
                Console.WriteLine(valor < saldo ? $"Saque realizado com sucesso {saldo -= valor}" : $"Saldo insuficiente");
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}
