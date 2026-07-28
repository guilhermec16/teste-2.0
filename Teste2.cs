public class Program
{
    public static void Main(string[] args)
    {

        string aluna;
        double n1;
        double n2;
        double n3;
        double n4;
        double media;

        Console.WriteLine("Qual Seu nome?");
        aluna = Console.ReadLine();

        Console.WriteLine("QUal a primeira nota?");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("QUal a segunda nota?");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("QUal a terceira nota?");
        n3 = double.Parse(Console.ReadLine());

        Console.WriteLine("QUal a quarta nota?");
        n4 = double.Parse(Console.ReadLine());

        media = (n1 + n2 + n3 + n4) / 4;

        if (media >= 6)
        {
            Console.WriteLine(aluna + " Foi Aprovado(a) com Média: " + media);

        }

        else {
            Console.WriteLine(aluna + " Foi Reprovado(a) Com Média: " + media);
        }
    }
}