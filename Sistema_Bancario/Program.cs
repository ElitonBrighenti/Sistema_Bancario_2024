namespace Sistema_Bancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero da conta: ");
            int num = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o nome do usuario: ");
            string nome = Console.ReadLine()!;
            ContaBancaria conta = new ContaBancaria(num, nome);

            while (true)
            {
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Consultar saldo");
                Console.WriteLine("0 - Sair");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Console.Write($"Diga o valor a depositar: ");
                        double valor = double.Parse(Console.ReadLine()!);
                        conta.Depositar(valor);
                        break;
                    case 2:
                        Console.Write($"Digite o valor a sacar: ");
                        double valor2 = double.Parse(Console.ReadLine()!);
                        conta.Sacar(valor2);
                        break;
                    case 3:
                        Console.Write($"Seu saldo é de: {conta.ConsultarSaldo}");
                        break;
                    case 0:
                        Console.Write($"Até logo");
                        Thread.Sleep(3000);
                        return;
                }
            }
        }
    }
}
