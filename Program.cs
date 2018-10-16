using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
           Console.WriteLine("Write a word to convert to pig latin: ");

            const string vowels = "AEIOUaeio"; // vowels are declared and newWords is set as a list string, user input is read in and stored.
            List<string> newWords = new List<string>();
            string sentence = Console.ReadLine();




            foreach (string word in sentence.Split(' ')) // string "word" and user "sentence" is split into substrings   
            {
                string firstLetter = word.Substring(0, 1); // firstLetter, restOfWord are made into it's own substring
                string restOfWord = word.Substring(1, word.Length - 1); 
                int currentLetter = vowels.IndexOf(firstLetter); 

                if (currentLetter == -1) // if a consonants is entered first it flips it to the end and adds "ay"
                {
                    newWords.Add(restOfWord + firstLetter + "ay");
                }
                else // if a vowel is first ditected add way 
                {
                    newWords.Add(word + "way");  
                }
                
                
                
          



            }

            

            for (i = 0; i < newWords.Count; i++) // the for loop goes as long many charictures new word   
            {
                Console.Write( " " + newWords[i]); // writes out new word and YOU NEED TO MACH YOU LOOP INDEX I
            }

                    


        }    
    }
}
