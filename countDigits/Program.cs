using System;

namespace countDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 567895;
            int count = 0;

            if (num == 0)
            {
                count++;
            }
            else
            {
                while (num != 0)
                {
                    num -= num % 10;
                    num /= 10;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
