using System;
using System.Collections.Generic;

namespace ADS_Recursion_11.Service
{
    static class NumberGenerator
    {
        public static List<int> Random(int size, int minValue, int maxValue)
        {
            var random = new Random();
            var randomList = new List<int>();

            for (int i = 0; i < size; i++)
                randomList.Add(random.Next(minValue, maxValue));

            return randomList;
        }
    }
}
