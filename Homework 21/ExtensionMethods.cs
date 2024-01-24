using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21
{
    internal static class ExtensionMethods
    {
        public static bool IsOdd(int[] nums)
        {
            for (int i = 0;i<nums.Length;i++)
            {
                if (nums[i] % 2 == 0) 
                    return false;
            }
            
            return true;
        }

        public static bool IsEven(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    return true;
            }

            return false;
        }

        public static bool IsContainsDigit(string[] str)
        {
            for(int i = 0;i<str.Length ; i++)
            {
                if (Convert.ToChar(str[i]).IsDigit) return true;
            }
            return false;
        }

        public static string ToCapitalize(string[] str)
        {
            for(int i=0;i<str.Length ;i++)
            {
                for (Convert.ToChar(str[i]).IsUpper) return str[i];
            }
        }

        public static string GetValusIndexes(string[] str)
        {
            for(int i=0 ;i<str.Length ;i++)
            {
                Convert.ToChar(str[i]);
                str[i].IndexOf((char)i);
                return str[i];
            }
            return str.(Convert.ToInt32(str[0]));
        }

        public static string GetFirstSentence(string[] str)
        {
            for(int i=0; i<str.Length ;i++)
            {
                Convert.ToChar(str[i]);
                str[i].Substring(0,(str[i].IndexOf('.')-0));
            }
            return str[0];
        }

        public static string GetSecondWord(string[] str)
        {
            for(int i=0;i<str.Length ;i++)
            {
                Convert.ToChar(str[i]);
                str[i].Substring(str[i].IndexOf(' ')+1, str[i].IndexOf(' '));
            }
            return str[0];
        }


    }
}
