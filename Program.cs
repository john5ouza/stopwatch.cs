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

            Console.WriteLine("WELCOME TO STOPWATC#!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("TYPE [S] FOR SECOND (10s = 10 SECONDS)");
            Console.WriteLine("TYPE [M] FOR MINUTE (10m = 10 MINUTES)");
            Console.WriteLine("TYPE [0] FOR EXIT");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("COUNT THE TIME: ");

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

            Console.WriteLine("READY...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
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

            Console.WriteLine("STOPWATC# IS FINISHED!");

            Thread.Sleep(2000);

            Menu();

        }

    }
}
