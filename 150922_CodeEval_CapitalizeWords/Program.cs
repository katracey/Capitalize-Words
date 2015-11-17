using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _150922_CodeEval_CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Write a program which capitalizes the first letter of each word in a sentence.
            */
            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
        }
    }
}*/
            //Plan: split into string array based on spaces, pull each string out separately to capitalize for index 0 of each word

            StreamReader reader = new StreamReader("..\\..\\Input.txt");
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] inputArr = line.Split(' ');

                    for (int i = 0; i < inputArr.Length; i++)
                    {
                        string word = inputArr[i];
                        char letter = word[0];
                        letter = char.ToUpper(letter);
                        Console.Write(letter);
                        for (int c = 1; c < word.Length; c++)
                        {
                            Console.Write(word[c]);
                        }
                        Console.Write(" ");

                    }
                    Console.WriteLine();
                    line = reader.ReadLine();
                }
            }
          

            

            
            


        }
    }
}
