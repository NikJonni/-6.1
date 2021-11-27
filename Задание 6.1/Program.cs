using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string fhrase = Console.ReadLine();// ввод текста
            string[] fhraseArray = fhrase.Split();// разделение строки на массив слов
            int max = 0, index1 = 0;
            for (int i = 0; i < fhraseArray.Length; i++)
                if (fhraseArray[i].Length > max)
                {
                    max = fhraseArray[i].Length;
                    index1 = i;
                }
            Console.WriteLine("Самое длинное слово: {0}", fhraseArray[index1]);
            Console.ReadKey();
        }
    }
}
