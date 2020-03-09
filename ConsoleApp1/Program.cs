using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            string path = @"Data\dane.csv";

            //Wczytywanie

            var fi = new FileInfo(path);
            var stream = new StreamReader(fi.OpenRead());

            string line = null;

            while ((line = stream.ReadLine()) != null)
            {
                Concole.WriteLine(line);
            }

            stream.Dispose();

        }

    }
}
