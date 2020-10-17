using System;
using System.IO;
using System.Collections;

namespace dotnet
{

    class Program
    {
        public static void bindCodeToField()
        {
            ArrayList codeLists = new ArrayList();
            ArrayList fieldLists = new ArrayList();
            using (StreamReader sr = new StreamReader("./data.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    codeLists.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader("./data1.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fieldLists.Add(line);
                }
            }

            for (int i = 0; i < codeLists.Count; i++)
            {
                Console.WriteLine($"{codeLists[i]}='{fieldLists[i]}',");
            }
        }
        public static void bindCodeToId(int temp = 4, int end = 4, string table = "B12", int libraryId = 9, int tableId = 12)
        {
            string attr = "ADD";
            for (int i = 0; i < temp + 1; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine($"{table}00{i}={libraryId}{tableId}{i},");
                }
                else
                {
                    Console.WriteLine($"{table}0{i}={libraryId}{tableId}{i},");
                }
            }
            for (int i = 0; i < end + 1; i++)
            {
                Console.WriteLine($"{table}{attr}0{i}={libraryId}{tableId}{temp + i + 1},");
            }
        }
        public static void renderTableId(string table, int number, string objName)
        {
            for (int i = 1; i < number + 1; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine($"{table}0{i}:{objName}{table}0{i}FI,");
                }
                else
                {
                    Console.WriteLine($"{table}{i}:{objName}{table}{i}FI,");
                }
            }
        }
        static void Main(string[] args)
        {
            // bindCodeToId(4, 4, "C10", 10, 10);
            bindCodeToField();
            // renderTableId("H", 13, "JudicialPrecedent");
            // for (int i = 0; i < oldLists.Count; i++)
            // {
            //     if (i == 0)
            //     {
            //         newLists.Add(oldLists[i].ToString().Split("/")[2]);
            //         Lists.Add(oldLists[i]);
            //     }
            //     else if (newLists.Contains(oldLists[i].ToString().Split("/")[2]) == false)
            //     {
            //         newLists.Add(oldLists[i].ToString().Split("/")[2]);
            //         Lists.Add(oldLists[i]);
            //     }
            // }
            // foreach (string url in Lists)
            // {
            //     Console.WriteLine("{0}", url);
            // }
            // string[] arrString = (string[])Lists.ToArray(typeof(string));
            // System.IO.File.WriteAllLines(@"./newTestData.txt", arrString, Encoding.UTF8);
        }
    }
}