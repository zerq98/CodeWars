using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu.CountCharactersInYourString
{
    public class CountCharactersInYourStringSolutions
    {
        public static Dictionary<char, int> Solution(string str)
        {
            var charsDictionary = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charsDictionary.ContainsKey(c))
                {
                    charsDictionary[c] += 1;
                }
                else
                {
                    charsDictionary.Add(c, 1);
                }
            }

            return charsDictionary;
        }
    }
}
