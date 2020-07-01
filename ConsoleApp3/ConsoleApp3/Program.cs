using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your word: ");
            string testWord = Console.ReadLine();
            string[] allText = System.IO.File.ReadAllText(@"some.txt"/*, System.Text.Encoding.Unicode*/).Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries); //все предложения, или другая кодировка
            foreach (string s in allText)
            {
                string[] words = s.Split(new char[] { ',', ';', '-', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries); //массив по коророму вы разделяете предложение на слова (можете усовершенствовать)
                int count = 0;
                foreach (string word in words)
                {
                    if (word.Equals(testWord, StringComparison.CurrentCultureIgnoreCase))
                    {
                        count++;
                    }
                }
                Console.WriteLine(s.Trim() + " - " + count);
            }
            Console.ReadKey();
        }
    }
}
