using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal4_with_cs
{
    class Program
    {
        //برنامه ای بنویسید که یک عدد از کاربر دریافت کند و مشخص کند ان عدد مربع کامل است یا خیر 
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (issquare(number)) Console.WriteLine("it is square.");
            else Console.WriteLine("it is not square.");
            Console.ReadKey();
        }
        static bool issquare(int x)
        {
            for(int i=1;i<=x;i++)
            {
                if ((i * i) == x) return true;
            }
            return false;
        }
    }
}
