using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib_03;

/* Вариант 27
Дана строка.Словом текста считается любая последовательность букв латинского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Разместить в строке последовательность ее слов в обратном порядке. */

namespace _3_2_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stroka stroka = new Stroka();
            stroka.text = "Это пример текста";
            string[] myWords = stroka.SplitToWords();

            string newString = "";
            for (int i = myWords.Length - 1; i >= 0; i--)
                newString += myWords[i] + " ";

            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
