using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 10m = 10 minutos");
            Console.WriteLine("0s = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 2, 1));
            char regressive = char.Parse(data.Substring(data.Length - 1, 1));
            int time;
            if (regressive == 'r')
            {
                time = int.Parse(data.Substring(0, data.Length - 2));
            }
            else
            {
                time = int.Parse(data.Substring(0, data.Length - 1));
            }

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                Console.WriteLine("Encerrando a aplicação...");
                Thread.Sleep(1000);
                Console.WriteLine("Aplicação finalizada...");
                System.Environment.Exit(0);
            }

            if (regressive == 'r')
            {
                PreStart(time * multiplier, true);
            }
            else
            {
                PreStart(time * multiplier);
            }


        }

        static void PreStart(int time, bool regressive = false)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time, regressive);
        }
        static void Start(int time, bool regressive = false)
        {
            int currentTime = 0;

            if (regressive == true)
            {
                for (currentTime = time; currentTime != 0; currentTime--)
                {
                    Console.Clear();
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }

            }
            else
            {
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }

            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(1500);

            Menu();
        }
    }
}

