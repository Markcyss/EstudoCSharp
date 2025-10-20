namespace EstudoCSharp;

class Program
{
    static void Main(string[] args)
    {
        Apresentar();

        decimal qtd = PedirValor("Informe a quantidade de Açaís que deseja (cada um custa R$13,50):");

        decimal conta = FazerConta(qtd);

        FormularResposta(conta);
    }

    static void Apresentar()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("==   Programa do Açaí    ==");
        Console.WriteLine("===========================");
    }

    static decimal PedirValor(string msg)
    {
        Console.WriteLine(msg);
        int valor = Convert.ToInt32(Console.ReadLine());
        return valor;
    }

    static decimal FazerConta(decimal qtd)
    {
        decimal conta = 13.50m * qtd;
        return conta;
    }

    static void FormularResposta(decimal conta)
    {
        Console.WriteLine($"Você precisará fazer {conta} paradas para abastecer.");
    }
}