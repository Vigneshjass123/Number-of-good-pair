using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Good_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 1, 1, 3 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])

                    {
                        Console.Write(a[i]);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
    

    

