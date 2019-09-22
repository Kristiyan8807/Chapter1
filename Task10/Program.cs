using System;

namespace Task10
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 100; ++i)
            {
                Console.WriteLine(i % 2 == 1 ? -i : i);
            }
        }
    }
}
