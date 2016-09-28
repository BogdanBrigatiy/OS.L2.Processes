using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teylor
{
    class Program
    {
        static void Main(string[] args)
        {
            double StartPosition = double.Parse(args[0]);
            double EndPosition = double.Parse(args[1]);
            double dX = double.Parse(args[2]);

            //StreamWriter w = new StreamWriter("E:\\TeylorLog.txt");
            //w.WriteLine(StartPosition);
            //w.WriteLine(EndPosition);
            //w.Close();

            double eps = 0.000000001;

            Console.WriteLine(string.Format("{0,-14} {1,-14}", "X", "Y"));

            for (double i = StartPosition; i <= EndPosition; i+=dX )
            {
                int n = 1;
                //double sum = 0;
                double an = 1;
                double sum = an;

                while (eps <= Math.Abs(an))
                {
                    an = (Math.Pow(-1, n) * Math.Pow(i, 2 * n)) / Fact(2 * n);
                    ++n;
                    sum += an;
                }
                Console.WriteLine(string.Format("{0,-14:0.########}  {1,-14:0.########}", i, sum));
            }
            //Console.WriteLine(string.Format("{0,14:0.##########}",dX));
            //Console.ReadKey();
            
        }

        static long Fact(int num)
        {
            long multy = 1;
            while (num > 0)
            {
                multy *= num;
                --num;
            }
            return multy;
        }
    }
}
