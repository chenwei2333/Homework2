using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("输入一个数字：");
            
            long num = long.Parse(Console.ReadLine());
            
            Console.WriteLine("其质因子如下所示：");
           
            Console.WriteLine(getResult(num));
        }
        public static String getResult(long num)
        {
            StringBuilder cw = new StringBuilder();
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                while (true)
                {
                    if (num % i == 0)
                    {
                        cw.Append(i);
                        cw.Append(" ");
                        num /= i;
                    }
                    else
                    {
                        break;
                    }
              }
            }
            if (num != 1)
            {
                cw.Append(num);
                cw.Append(" ");
            }
            return cw.ToString();
        }
    }
}

