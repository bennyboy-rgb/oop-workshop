using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class findletter
    {
       public findletter()
        {
            //MostCommonLetterInString("abcdefgggghhhhhhhh"); 
            string[] lines = File.ReadAllLines("C:/Users/Computing/Downloads/Words.txt");
            foreach (string line in lines )
            {
                //Console.WriteLine(line);
                MostCommonLetterInString(line);

            }
        }
        private int counter(string line, char characterToFind)
        {
            int count = 0;
            foreach (char currentCharacter in line)
            {
               if (currentCharacter == characterToFind)
                { count++;
                  
                }
                    
            }
            return count;
        }
        private void MostCommonLetterInString(string line)
        {
            char mostcommonecharacter='-';
            int mostcommoncharactercount = 0;
            
            foreach (char currentCharacter in line)
            {
                
                int currentlettercount = counter(line, currentCharacter);
                if (currentlettercount > mostcommoncharactercount)
                {
                    mostcommoncharactercount = currentlettercount;
                    mostcommonecharacter = currentCharacter;
                }
                
            }
            Console.Write(mostcommonecharacter);

        }


        
    }
    
}
