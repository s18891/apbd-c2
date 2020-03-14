using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pathCsv = @"Dane\dane.csv";
            string pathXml = @"data.xml";

            if (args.Length==3)
            {
                            Console.WriteLine(args[0]);
                            Console.WriteLine(args[1]);
                            Console.WriteLine(args[2]);
                            pathCsv = args[0];
                            pathXml = args[1];



            }

            //Wczytywanie
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            var fi = new FileInfo(pathCsv);
            if (!fi.Exists)
            {
                File.AppendAllText(@"log.txt", "Błędna ścieżka pliku źródłowego"+Environment.NewLine);

            }
            else
            {

                var stream = new StreamReader(fi.OpenRead());

                string line = null;
                string[] splitLine = null;
                var list = new List<Student>();



                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    splitLine = line.Split(',');


                    if (splitLine.Length != 9)
                    {
                        Console.WriteLine("ERROR");
                        File.AppendAllText(@"log.txt", "Błędna ilośc kolumn w wierszu w pliku wejściowym"+Environment.NewLine);

                    }







                    //stream.Dispose();


                    //XML


                    var st = new Student
                    {
                        Imie = splitLine[0],
                        Nazwisko = splitLine[1],
                        kierunekStudiow = splitLine[2],
                        typStudiow = splitLine[3],
                        numerstudenta = splitLine[4],
                        dataUrodzenia = splitLine[5],
                        email = splitLine[6],
                        imieMatki = splitLine[7],
                        imieOjca = splitLine[8],



                    };
                    list.Add(st);
                }

                FileStream writer = new FileStream(pathXml, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                    new XmlRootAttribute("uczelnia"));

                serializer.Serialize(writer, list);
                writer.Dispose();



            }
        }


    }
}