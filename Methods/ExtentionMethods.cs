using System;
using System.Collections.Generic;
using System.Text;

namespace _18Aug_HomeWorkTask1.Methods
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int number) 
        {
            if (number % 2!=0)
            {
                return true;
            }
            return false;
        
        }
        public static bool IsEven(this int number) 
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
            //if (number.IsOdd() == false)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
        public static bool IsContainsDigit(this string word) 
        {
            foreach (char item in word)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }

            }
            return false;
        }
        public static string ToCapitalize(this string word) 
        {
            StringBuilder capitalize = new StringBuilder();
            capitalize.Append(char.ToUpper(word[0]));
            capitalize.Append(word.Substring(1).ToLower());
            return capitalize.ToString();
            
        }
        public static int[] GetValueIndexes(this string word,char symbol) 
        {
            int[] indexOf = new int[0];
            int count = 0;
            
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    count++;
                    Array.Resize(ref indexOf, count);
                    indexOf[count-1] = i;
                    
                }
            }
            return indexOf;
            
            
        
        }
    }
}
