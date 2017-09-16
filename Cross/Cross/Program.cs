using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "##d",
                           "###",
                           "##d",
                           "##d",
                           "###",
                           "##d",
                           "##d",
                           "###",
                           "##d" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            FindCross(a);
            Console.Read();
        }
        public static void FindCross(string[] a)
        {
            bool c = true;
            for (int i = 1; i < a.Length-1; i++)
            {
                char[] d=a[i].ToCharArray();
                for (int j = 1; j < d.Length-1; j++)
                {
                    if ((d[j]=='#')&&(d[j-1] == '#')&&(d[j+1] == '#'))
                    {
                        if ((a[i - 1].ToCharArray()[j] == '#')&&(a[i + 1].ToCharArray()[j] == '#'))
                        {
                            Console.WriteLine(@"I find it: x={0} y={1}.",j,i);
                            c = false;
                        }
                    }
                }
            }
            if (c)
            {
                Console.WriteLine("Cross doesn't exist.");
            }
        }
    }
}
