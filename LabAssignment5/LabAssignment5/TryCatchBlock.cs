using System;

namespace LabAssignment5
{
    class TryCatchBlock
    {
        static void Main()
        {
            try
            {
                Math math = new Math();
                Console.WriteLine($"SI is:" + math.SimpleInterest2(2456, Time: 3));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
                GC.Collect();
            }
        }
    }
}
           
