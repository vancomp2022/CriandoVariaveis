// See https://aka.ms/new-console-template for more information

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Executando Projeto2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = idade + 5;
            Console.WriteLine(idade);

            idade = idade + 5 * 2;
            Console.WriteLine(idade);

            idade = (idade + 5) * 2;
            Console.WriteLine("Sua idade eh " + idade + "!");



            Console.WriteLine("Execucao Finalizada - Tecle enter para sair ..");
    
            Console.ReadLine();
        }

    }

}
