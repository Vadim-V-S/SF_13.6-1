using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace SF_13._6_1
{
    class Program
    {
        static string path = @"C:/Users/Savinykh/Desktop/С/Text1.txt";
        static List<string> list = new List<string>();
        static LinkedList<string> linkedList = new LinkedList<string>();
        static string str;

        static void Main(string[] args)
        {
            int iter = 20;

            RunTest(iter);

            Console.ReadKey();
        }


        static void RunTest(int iter)
        {
           long[] t = new long[iter];
            var timer = new Stopwatch();

            for (int i = 0; i < iter; i++)
            {
                list.Clear();
                //linkedList.Clear();

                timer.Restart();

                CreateList();  // 10 миллисекунд
                //CreateLinkedList(); //11 миллисекунд

                timer.Stop();

               t[i] = timer.ElapsedMilliseconds;
            }

            Array.Sort(t);
            Console.WriteLine("Медианное время работы списка {0} мидисекунд", t[iter / 2]);
        }

        static void CreateList()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    list.Add(str);
                }
            }
        }

        static void CreateLinkedList()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    linkedList.AddLast(str);
                }
            }

        }
    }
}
