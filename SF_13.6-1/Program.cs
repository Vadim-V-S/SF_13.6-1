using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace SF_13._6_1
{
    class Program
    {
        static string path = @"C:/Users/Savinykh/Desktop/С/Text1.txt";

        static void Main(string[] args)
        {

            var timer = new Stopwatch();
            timer.Start();

            //CreateList();  // 70 миллисекунд
            CreateLinkedList(); //62 миллисекунды

            timer.Stop();
            Console.WriteLine($"Время: {timer.ElapsedMilliseconds} милписекунд");


            Console.ReadKey();
        }

        static void CreateList()
        {
            var list = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string str;
                while((str=reader.ReadLine())!=null)
                {
                    list.Add(str);
                }
            }
        }

        static void CreateLinkedList()
        {
            var linkedList = new LinkedList<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    linkedList.AddLast(str);
                }
            }

        }
    }
}
