using System;

namespace LabAssignment5
{
    class SimpleInterest
    {
        static void Main()
        {
            int P, T;
            float R, SI;
            Console.Write("Enter the Amount:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate:");
            R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Time:");
            T = Convert.ToInt32(Console.ReadLine());
            SI = P * T * R / 100;
            Console.WriteLine("Simple Interest is : {0}", SI);
            Console.ReadLine();
        }
    }
}
