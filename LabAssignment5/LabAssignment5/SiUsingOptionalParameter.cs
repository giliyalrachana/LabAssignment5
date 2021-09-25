using System;


namespace LabAssignment5
{
    class SiUsingOptionalParameter
    {
        static void Main()
        {
            Console.Write("Enter the Amount P");
            int P = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate R");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Enter Time T");
            int T = int.Parse(Console.ReadLine());
            SiUsingOptionalParameter si = new SiUsingOptionalParameter();

            double TotalSimpleInterest = si.OptionalInterest(P, T, R = 15);
            Console.WriteLine(TotalSimpleInterest);
            Console.ReadLine();
        }

        public double OptionalInterest(int P, int T, int R)
        {
                int total = P * T * R;
                double d = total / 100;
                
                return d;
            }
    }
}
