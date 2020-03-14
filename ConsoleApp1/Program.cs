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
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            string path = @"Dane\dane.csv";

            //Wczytywanie

            var fi = new FileInfo(path);
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
                }
            



            
        

            //stream.Dispose();


            //XML


            var st = new Student
            {
                Imie =splitLine[0],
                Nazwisko=splitLine[1],
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
            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                new XmlRootAttribute("uczelnia"));

            serializer.Serialize(writer, list);
            writer.Dispose();




        }


    }
}
