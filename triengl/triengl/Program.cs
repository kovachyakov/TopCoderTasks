using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triengl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a =Convert.ToInt32(Console.ReadLine());
            string line = "";
            for (int i = 0; i < a; i++)
            {
                int n =i*2+1;
                int space = a - i-1;


                for (int j = 0; j < a; j++)
                {
                    if (j!=0)
                    {
                        space= 2*(a - i - 1)+1;
                    }
                
                    for (int g = 0; g < space; g++)
                    {
                        line = line + " ";
                    }
                    for (int t = 0; t < n; t++)
                    {
                        line = line + "*";
                    }
                }
                Console.WriteLine(line);
                line = "";
            }
            Console.Read();
        }
    }
}
