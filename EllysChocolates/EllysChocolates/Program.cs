using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllysChocolates
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = 1;//chocolate value
            int K = 3;//exchange wrappers 
            int N = 15;//money
            getCount(P,K,N);
            Console.Read();
        }
        public static void getCount(int P,int K,int N)
        {
            int answer=0;
            int wrapper = 0;
            while ((N >= P) || (wrapper >= K))
            {
                while (N >= P)
                {
                    N =N-P;
                    answer++;
                    wrapper++;
                }
                while (wrapper >= K)
                {
                    wrapper = wrapper - K+1;
                    answer++;
                }
            }
            Console.WriteLine("You ate {0} chocolates.", answer);
        }
    }
}
