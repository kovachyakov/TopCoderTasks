using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterAndOxygen
{
    class Program
    {
        static void Main(string[] args)
        {
            double remainH2O = 123456789;//numb 3 and 4 example?
            double remainO2 = 987654321;
            int costH2O = 123;
            int costO2 = 456;
            
            getCount(costH2O, costO2, remainH2O, remainO2);
            Console.Read();
        }
        public static void getCount(int costH2O, int costO2, double remainH2O,double remainO2)
        {
            double answer = 0;
            while ((remainH2O >= costH2O) && (remainO2 >= costO2))
            {
                remainH2O -= costH2O;
                remainO2 -= costO2;
                answer++;
                if ((remainO2 < costO2) && (remainH2O > costH2O))
                {
                    double x = remainH2O / (costH2O + 2 * costO2);
                    remainH2O = costH2O * x;
                    remainO2 += costO2 * x;
                }
            }
            Console.WriteLine("______________");
            //while ((remainO2 < costO2) && (remainH2O > costH2O))
            //{
            //    double x = remainH2O / (costH2O + 2 * costO2);
            //    remainH2O = costH2O*x;
            //    remainO2 += costO2 * x;
            //}

            //if (remainH2O / costH2O >= remainO2 / costO2)
            //{
            //    answer += remainH2O / costH2O;
            //}
            //if (remainH2O / costH2O <= remainO2 / costO2)
            //{
            //    answer += remainO2 / costO2;
            //}

            if ((remainH2O < remainO2) && (remainH2O / costH2O <= remainO2 / costO2))
            {
                answer += remainH2O / costH2O;
                remainH2O -= remainH2O;
            }
            if ((remainH2O < remainO2) && (remainH2O / costH2O >= remainO2 / costO2))
            {
                answer += remainO2 / costO2;
                remainO2-= remainO2;
            }
            
            if ((remainH2O > remainO2) && (remainO2 / costO2 >= remainH2O / costH2O))
            {
                answer += remainH2O / costH2O;
                remainH2O -= remainH2O;
            }


            Console.WriteLine("Return: {0}.", answer);
            if (remainH2O==0)
            {
                Console.WriteLine("Haven't water");
            }
            if (remainO2==0)
            {
                Console.WriteLine("Haven't oxigen");
            }
        }
    }
}
