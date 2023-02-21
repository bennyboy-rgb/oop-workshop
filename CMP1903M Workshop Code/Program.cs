using System;
using System.Diagnostics.Metrics;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 4
            //Challenge:  Determine what the value of the accumulator will be when the code is finished running
            string[] code = File.ReadAllLines("C:/Users/Computing/Downloads/Week 4 Codes.txt");

            int increment = 0;
            int accumulator = 0;
            for (int i = 0; i < code.Length; i += increment)
            {
                string[] instructionParts = code[i].Split(' ');
                string op = instructionParts[0];
                int operand = Convert.ToInt32(instructionParts[1]);

                if (op == "acc")
                {
                    accumulator += operand;
                    increment = 1;
                }
                else if (op == "jmp")
                {
                    increment = operand;
                }
                else if (op == "nop")
                {
                    increment = 1;
                }

                //Console.WriteLine(code[i]);
            }
            //Console.WriteLine(accumulator);

            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i; 

            }
            
            //Read each line of the input.
            //Determine whether it is a 'acc' or 'jmp' command for each line
            //Determine the value on each line
            //Find the value of 'acc' at the end
            //HINT: We can read each line as an array (or List) of strings; check [0] for 'a' or 'j', then check [4] and [5] for the values
            //OR: we could split each string at the space into an operation string and a value string
            //Can we read line by line instead of storing in a collection?


            //Week 4
            //Task 1: Add constructors to the Person() class
            //Task 2: create a 'screenName' field within Person
            //Task 3: Create a 'collection' of Person, iterate (i.e. loop) through the collection outputting data for each Person

      
        }
    }
}
