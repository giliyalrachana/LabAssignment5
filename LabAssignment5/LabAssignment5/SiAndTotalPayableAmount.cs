using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment5
{
    class SiAndTotalPayableAmount
    {
        static void Main()
        {
            Console.Write("Enter the Amount(P)");
            int P = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate(R)");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Enter Time(T)");
            int T = int.Parse(Console.ReadLine());
            SiAndTotalPayableAmount si = new SiAndTotalPayableAmount();
            double totalAmount;
            Console.WriteLine($"Simple interest is{si.Interest(P, T, R, out totalAmount)}");
            Console.WriteLine($"Total amount is{totalAmount}");
            Console.ReadLine();
        }
        public double Interest(int p, int t, int r, out double totalPayable)
        {
            {
                int total = p * t * r;
                double d = total / 100;
                double tp = d + p;
                totalPayable = tp;

                return tp;
            }
        }
    }
}
         
