using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Test
{
    public class DicTest
    {
        const int numIter = 4000000;
        private Dictionary<int, string[]> d1;
        private Dictionary<int, int[]> d2;

        [GlobalSetup]
        public void GlobalSetup()
        {
            d1 = new Dictionary<int, string[]>();
            d2 = new Dictionary<int, int[]>();
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            d1.Clear();
            d2.Clear();
        }

        public void Both ()
        {
            for (int i = 0; i < numIter; i++)
            {
                string[] sarr = new string[10];
                for (int j = 0; j < 10; j++)
                {
                    sarr[j] = j.ToString();
                }
                int[] iarr = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    iarr[j] = j;
                }
                d1[i] = sarr;
                d2[i] = iarr;
            }
        }

        public void One ()
        {
            for (int i = 0; i < numIter; i++)
            {
                string[] sarr = new string[10];
                for (int j = 0; j < 10; j++)
                {
                    sarr[j] = j.ToString();
                }
                int[] iarr = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    iarr[j] = j;
                }
                d1[i] = sarr;
                // d2[i] = iarr;
            }
        }

        [Benchmark]
        public void TestBoth() => Both();

        [Benchmark]
        public void TestOne() => One();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<DicTest>();
        }
    }
}
