using _18Aug_HomeWorkTask1.Methods;
using System;

namespace _18Aug_HomeWorkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 342;
            int NewNumb = 231;
            string word = "ceyhun9712 mustafayev";
            char symbol = 'e';
            int[] array = word.GetValueIndexes(symbol);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(word.ToCapitalize());
            Console.WriteLine(word.IsContainsDigit());
            Console.WriteLine(number.IsEven());
            Console.WriteLine(NewNumb.IsOdd());







        }
    }
}
