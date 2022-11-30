using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal3_with_cs
{
    //برنامه ای بنویسید که عدی را دریافت کرده و مشخص کند ان عدد در تقارن مثلثی صدق میکند یا خیر 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a positive integer number : ");
            uint number = Convert.ToUInt32(Console.ReadLine());
            if (istrain(number) == 1) Console.WriteLine("it is a train number.");
            else Console.WriteLine("it is not a train number.");
            Console.ReadKey();
        }
        static int istrain(uint x)
        {
            x *= 2;
            for(int i=1;i<=(x/2);i++)
            {
                if (i * (i + 1) == x) return 1;
            }
            return 0;
        }
    }
}
