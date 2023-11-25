using System.ComponentModel.Design;
using System.Threading;
using Microsoft.VisualBasic;
namespace StopWatch;
class Program
{
    static void Main(string[] args)
    {
        Menu();

    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 Segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;


        if (type == 'm')
            multiplier = 60;
        if (time == 0)
            System.Environment.Exit(0);
        PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Prepara Largatixo...");
        Thread.Sleep(1000);
        Console.WriteLine("Se prepara Crefiso");
        Thread.Sleep(1000);
        Console.WriteLine("VAAAIII Magazine Luizo!!!");
        Thread.Sleep(1000);

        Start(time);
    }
    static void Start(int time)
    {
        int currentTime = 0;
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Contagem finalizada, Voltando ao menu");
        Thread.Sleep(1500);
        Menu();
    }
}