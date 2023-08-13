using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 70,20,60,80,50,80};
            double cal_mean(double[] a)
            {
                double avg = a.Average();
                return avg;
            }
            double cal_median(double[] a)
            {
                double[] sort = (from i in a
                            orderby i
                            select i).ToArray();
                double len = sort.Length;
                Console.WriteLine("legth : " + len);
                foreach (double i in sort)
                {
                    Console.WriteLine(i + " ");
                }
                double median;
                if (len % 2 == 0)
                {
                    median = sort[Convert.ToInt32(((len / 2) + ((len / 2) - 1))/2)];
                }
                else
                {
                    median = sort[Convert.ToInt32((len - 1) / 2)];
                }
                return median;
            }
           
            double cal_mode(double[] a)
            {
                var grouped = a.GroupBy(x => x);
                int maxCount = 0;
                int mode = 0;

                foreach (var group in grouped)
                {
                    if (group.Count() > maxCount)
                    {
                        maxCount = group.Count();
                        mode =Convert.ToInt32(group.Key);
                    }
                }
                return mode;
            }
            Console.WriteLine("mean " + cal_mean(array));
            Console.WriteLine("\nmedian " + cal_median(array));
            Console.WriteLine("\nMode " + cal_mode(array));
            Console.ReadKey();
        }
    }
}
