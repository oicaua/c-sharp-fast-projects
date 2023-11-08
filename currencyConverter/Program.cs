using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao conversor de moedas!");
        Console.WriteLine("Escolha uma moeda de origem:");
        Console.WriteLine("1. Euro (EUR)");
        Console.WriteLine("2. Dólar Americano (USD)");
        Console.WriteLine("3. Libra Esterlina (GBP)");
        Console.WriteLine("4. Real Brasileiro (BRL)");

        int moedaOrigem = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor a ser convertido:");
        double valorOrigem = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma moeda de destino:");
        Console.WriteLine("1. Euro (EUR)");
        Console.WriteLine("2. Dólar Americano (USD)");
        Console.WriteLine("3. Libra Esterlina (GBP)");
        Console.WriteLine("4. Real Brasileiro (BRL)");

        int moedaDestino = int.Parse(Console.ReadLine());

        double taxaDeCambio = 0.0;

        // Defina as taxas de câmbio de acordo com as moedas escolhidas
        if (moedaOrigem == 1) // Euro (EUR)
        {
            if (moedaDestino == 2) // Dólar Americano (USD)
                taxaDeCambio = 1.12;
            else if (moedaDestino == 3) // Libra Esterlina (GBP)
                taxaDeCambio = 0.85;
            else if (moedaDestino == 4) // Real Brasileiro (BRL)
                taxaDeCambio = 6.15;
        }
        else if (moedaOrigem == 2) // Dólar Americano (USD)
        {
            if (moedaDestino == 1) // Euro (EUR)
                taxaDeCambio = 0.89;
            else if (moedaDestino == 3) // Libra Esterlina (GBP)
                taxaDeCambio = 0.76;
            else if (moedaDestino == 4) // Real Brasileiro (BRL)
                taxaDeCambio = 5.49;
        }
        else if (moedaOrigem == 3) // Libra Esterlina (GBP)
        {
            if (moedaDestino == 1) // Euro (EUR)
                taxaDeCambio = 1.18;
            else if (moedaDestino == 2) // Dólar Americano (USD)
                taxaDeCambio = 1.31;
            else if (moedaDestino == 4) // Real Brasileiro (BRL)
                taxaDeCambio = 7.29;
        }
        else if (moedaOrigem == 4) // Real Brasileiro (BRL)
        {
            if (moedaDestino == 1) // Euro (EUR)
                taxaDeCambio = 0.16;
            else if (moedaDestino == 2) // Dólar Americano (USD)
                taxaDeCambio = 0.18;
            else if (moedaDestino == 3) // Libra Esterlina (GBP)
                taxaDeCambio = 0.14;
        }

        if (taxaDeCambio > 0)
        {
            double valorConvertido = valorOrigem * taxaDeCambio;
            Console.WriteLine($"O valor convertido é: {valorConvertido} {ObterNomeMoeda(moedaDestino)}");
        }
        else
        {
            Console.WriteLine("Moedas de origem ou destino inválidas.");
        }
    }

    static string ObterNomeMoeda(int codigoMoeda)
    {
        switch (codigoMoeda)
        {
            case 1:
                return "Euro (EUR)";
            case 2:
                return "Dólar Americano (USD)";
            case 3:
                return "Libra Esterlina (GBP)";
            case 4:
                return "Real Brasileiro (BRL)";
            default:
                return "Moeda Desconhecida";
        }
    }
}
