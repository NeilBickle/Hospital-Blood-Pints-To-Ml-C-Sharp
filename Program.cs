using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pints_To_ML
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;
            double ans;
            Console.WriteLine("Enter A Number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 1 For Pints To ML Or 2 For ML To Pints");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {
                ans = a * 473.176;
                Console.WriteLine("The Answer Is {0}", ans);
            }
            else if (b == 2)
            {
                ans = a / 473.176;
                Console.WriteLine("The Answer Is {0}", ans);
            }
            Console.ReadLine();
        }
    }
}
