using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu.MultipleOf3Or5
{
    public static class MultipleOf3Or5Solution
    {
        public static int Solution(int value)
        {
            int sum = 0;
            if (value <= 0) return sum;

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
