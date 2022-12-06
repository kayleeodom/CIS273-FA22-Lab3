using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool MeanMode(int[] array)
        {            
            return ComputeMode(array) == ComputeAverage(array);
        }

        // TODO
        private static double ComputeAverage(int[] array)
        {
            int answer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer += array[i];
            }

            double avg = answer / array.Length;
            //return 0.0;
            return avg;
        }

        // TODO
        private static double? ComputeMode(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach(int a in array)
            {
                if(counts.ContainsKey(a))
                {
                    counts[a]++;
                }
                else
                {
                    counts[a] = 1;
                }
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach(int key in counts.Keys)
            {
                if(max <= counts[key])
                {
                    max = counts[key];
                    result = key;
                }
            }

            return result;

        }
    }
}
