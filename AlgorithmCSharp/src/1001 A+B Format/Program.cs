using System;

namespace _1001_A_B_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input.Split(' ')[0]);
            int b = int.Parse(input.Split(' ')[1]);
            int sum = a + b;
            int abs = Math.Abs(sum);
            if (abs < 1000)
            {
                Console.WriteLine(sum);
            }
            if (abs >= 1000 && abs < 1000000)
            {
                Console.WriteLine($"{sum / 1000},{GetRes(abs % 1000)}");
            }
            if (abs >= 1000000)
            {
                Console.WriteLine($"{sum / 1000000},{GetRes((abs / 1000) % 1000)},{GetRes(abs % 1000)}");
            }
            Console.ReadKey();
        }
        static string GetRes(int input)
        {
            if (input==0)
            {
                return "000";
            }
            if (input>=100)
            {
                return input.ToString();
            }
            if (input>=10&&input<100)
            {
                return $"0{input}";
            }
            return $"00{input}";
        }
    }
}
