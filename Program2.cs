using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal2_with_cs
{
    //برنامه ای که یک عدد زوج را دریاغت کند و تمام زوج های اول که مجموع انها برابر خود عدد است را نمایش دهد
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an even number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                for (int i = 3; i <= (number / 2); i++)
                {
                    if (isprimenumber(i) && isprimenumber(number - i))
                        Console.WriteLine(i + " + " + (number - i) + " = " + number);
                }
            }
            else Console.WriteLine("wrong number !");
            Console.ReadKey();
        }
        static bool isprimenumber(int x)
        {
            for(int i=2;i<x;i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
