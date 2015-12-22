using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FareyNumber
    {
        public readonly uint N;
        public readonly uint D;

        public FareyNumber(uint n, uint d)
        {
            N = n;
            D = d;
        }

        public override string ToString()
        {
            string result = String.Format("{0}/{1}", N, D);
            return result;
        }
    }

    public class FareyNumbers
    {
        public readonly uint Num;
        public readonly uint Count;

        public readonly HashSet<FareyNumber> Numbers = new HashSet<FareyNumber>();

        public FareyNumbers(uint N)
        {
            Num = N;
            Count = 0;
            GenerateNumbers();
            Count = (uint)Numbers.Count;
        }

        private void GenerateNumbers()
        {
            if (Num == 1)
            {
                Numbers.Add(new FareyNumber(0, 1));
                Numbers.Add(new FareyNumber(1, 1));
            }
            if (Num == 2)
            {
                Numbers.Add(new FareyNumber(0, 1));
                Numbers.Add(new FareyNumber(1, 2));
                Numbers.Add(new FareyNumber(1, 1));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FareyNumbers numbers = new FareyNumbers(4);
            //Console.WriteLine("N={0}, FareyNumbers={1}", numbers.Num, numbers.ToString());
            Console.WriteLine("FareyNumber={0}", new FareyNumber(1,2));
        }
    }
}
