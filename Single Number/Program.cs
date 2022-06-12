using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1,2,1,3,2 };
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            foreach (var number in myArray)
            {
                if (number==1) 
                { 
                    count1++;
                }
                if (number==2) 
                {
                    count2++;
                }
                if (number==3) 
                {
                    count3++;
                }
            }
            if (count1==1) 
            {
                Console.WriteLine(1+" is the single number");
            }
            if (count2 == 1)
            {
                Console.WriteLine(2+" is the single number");
            }
            if (count3 == 1)
            {
                Console.WriteLine(3+" is the single number");
            }
        }
    }
}
