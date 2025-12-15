using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar){

        Console.WriteLine("Digite o nome do herói:");
        string nomeDoHeroi = Console.ReadLine();

        Console.WriteLine("Digite o XP Atual do herói:");
                   int xp;
            while (!int.TryParse(Console.ReadLine(), out xp))
            {
                Console.WriteLine("Digite um número válido para a XP:");
            }


        string nivel = "";

        switch (true)
        {
            case bool _ when xp <= 1000:
                nivel = "Ferro";
                break;

            case bool _ when xp <= 2000:
                nivel = "Bronze";
                break;

            case bool _ when xp <= 5000:
                nivel = "Prata";
                break;

            case bool _ when xp <= 7000:
                nivel = "Ouro";
                break;

            case bool _ when xp <= 8000:
                nivel = "Platina";
                break;

            case bool _ when xp <= 9000:
                nivel = "Ascendente";
                break;

            case bool _ when xp <= 10000:
                nivel = "Imortal";
                break;

            default:
                nivel = "Radiante";
                break;
        }

        Console.WriteLine("O Herói de nome " + nomeDoHeroi + " está no nível " + nivel);
    
    Console.WriteLine("Deseja cadastrar outro herói? (s/n)");
    string resposta = Console.ReadLine();

     if (resposta == null || resposta.Trim().ToLower() != "s")
            {
                continuar = false;
            }
        }
        Console.WriteLine("Programa finalizado.");
        Console.ReadLine();
    }

}

