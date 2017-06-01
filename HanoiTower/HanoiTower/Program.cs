using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("請輸入一個正整數(n > 0)");
            string input = Console.ReadLine();
            DateTime StartTime = DateTime.Now;
            if (int.TryParse(input, out n))
                move('A', 'B', 'C', n);
            else
                Console.WriteLine("這不是合法的正整數");
            DateTime EndTime = DateTime.Now;
            TimeSpan ts = EndTime.Subtract(StartTime);
            Console.WriteLine("It took " + ts.TotalSeconds + " s");
            Console.ReadLine();
        }

        static void move(char source,char temp,char des,int n)
        {
            if(n < 1)
            {
                Console.WriteLine("這不是合法數字");
            }
            else if (n == 1)
            {
                Console.WriteLine("move disk " + n + " from " + source + " to " + des);
            }
            else
            {
                move(source, des, temp, n - 1);
                Console.WriteLine("move disk " + n + " from " + source + " to " + des);
                move(temp, source, des, n - 1);
            }
        }
    }
}
