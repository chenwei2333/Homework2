using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIRD3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] visit = new int[101];
            for (int i = 2; i <= 100; i++)
            {
                if (visit[i] == 1) { continue; }
                for (int j = i + 1; j <= 100; j++)
                {
                    if (j % i == 0)
                    {
                        visit[j] = 1;
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}

