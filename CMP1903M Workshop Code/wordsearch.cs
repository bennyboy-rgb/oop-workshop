using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class wordsearch
    { 
        public wordsearch()
        {
            string[] lines = File.ReadAllLines("C:/Users/Computing/Downloads/Week 5 Passcodes.txt");
            foreach ( string line in lines)
            {
                List<string> list = line.Split(' ').ToList();
                //foreach (string word in list)
                //{
                //    if (word_occurrence(word, list) >= 2)
                //    {
                //        Console.WriteLine("false");
                //    }
                //    else
                //    {
                //        Console.WriteLine("true");
                //    }
                //}
                Console.WriteLine(validity(list));


                //foreach ( string word in line.Split(' '))
                //{

                //    Console.WriteLine(list);


                //}
            }
        }
        private int word_occurrence(string word, List<string> list) 
        { int counter = 0;
           foreach (string item in list)
            {
                if (item == word)
                {
                    counter++;
                }
            }
            return counter;
        }
        public bool validity(List<string> list)
        {
            List<bool> validitylist = new List<bool>();
            foreach (string item in list)
            {
                if (word_occurrence(item, list) >= 2)
                {
                    validitylist.Add(false);
                }
                else
                {
                    validitylist.Add(true);
                }
            }
            if (validitylist.Contains(false))
            {
                return false;
            }
            return true;

        }
    }
    
}
