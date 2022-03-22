using System;
using System.Collections.Generic;
using System.IO;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> cookies = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        if (!cookies.ContainsKey(line[0]))
                        {
                            cookies.Add(line[0], int.Parse(line[1]));
                        }
                        else
                        {
                            cookies.Add()
                        }

                    }
                    //Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
