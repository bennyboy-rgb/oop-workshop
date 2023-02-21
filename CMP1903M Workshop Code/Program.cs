using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //(-4, -5) and (-1, -1) describe two points. What is the distance between them?
            //int x1 = -4;
            //int y1 = -5;

            //int x2 = -1;
            //int y2 = -1;

            //int answer1 = 0;

           Console.WriteLine("the answer is : "+Method(-4, -1, -5, -1));
            //Problem 2
            //What is the denominator of the slope between these points?
           Console.WriteLine("the denominator is :" +Denominator(-1,-4));

            //Problem 3
            //What is the greatest common divisor (GCD) of 1124 and 136?
           Console.WriteLine("the common divisor is :" + Cmd());

            //Problem 4
            //What is the remainder, when you divide the square of the sum of the first ten natural numbers by ten?
            Console.WriteLine("the remainder is " +remainder());
            Console.WriteLine("the length of the string is :"+name("school of computing"));
            Console.WriteLine("the best divisor is : "+bestdivisor());
            Console.WriteLine(fibonacci));
        }
        static int Method(int x1, int x2, int y1, int y2)
        {
            int answer = Convert.ToInt32(Math.Pow(Convert.ToDouble(x2-x1), 2) + Math.Pow(Convert.ToDouble(y2-y1),2));
            int answer1 = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(answer)));
            return answer1;
        }
        static int Denominator(int x1,int x2)
        {
            return x2- x1;
        }
        static int Cmd()
        {  
            List<int> list  = new List<int>();
            for (int i = 1; i < 136; i++)
            {
                if (136 % i == 0 & 1124 %i ==0)
                {

                    list.Add(i);
                }
            }   
            return list.Last();
        }
        static int remainder()
        {
            int sum = 0;
            for (int i = 1; i <= 10;i++)
            {
                sum += i;
                
            }
            sum = sum*sum;
            sum = sum % 10;
            return sum;
        }
        static int name(string nameofschool)
        {   
            string benny =nameofschool.Replace(" ","");
            return benny.Length;
        }
        static int bestdivisor()
        {
            int sum = 0;
            for (int i=0;i<1000;i++)
            {
                
                if ( i%3 ==0 || i%5 == 0)
                {
                    sum += i;
                }
            }return sum;
        }
        static int fibonacci(int n)
        {
           // for (int i=0; i<=4000000;i++ ) { 
             //   if ()
            //}
          if (n ==0 || n == 1)
            {
                return n;
            }
          else
            {
                return fibonacci(n -1) +fibonacci(n-2);
            }
        }
    }
}
