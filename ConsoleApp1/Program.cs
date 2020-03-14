﻿using ConsoleApp1.Models;
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

            while ((line = stream.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        

            //stream.Dispose();


            //XML


            var list = new List<Student>();
            var st = new Student
            {
                Imie ="Jan",
                Nazwisko="Kowalski",
                Email="kowalski@wp.pl"
                
                


            };
            list.Add(st);

            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                new XmlRootAttribute("uczelnia"));

            serializer.Serialize(writer, list);
            writer.Dispose();




        }


    }
}
