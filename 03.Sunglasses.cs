/* Do you know that the next solar eclipse will occur on April 29, 2014?
 * It will be observable from South Asia, Australia, the Pacific and the Indian Oceans
 * and Antarctica. Spiro is an entrepreneur who wants to cash in on this natural phenomenon.
 * Help him produce protective sunglasses of different sizes. You will get 5% of the profit. */

using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int spaMid = 2*n - 2;
            int line = 1;
            int halfN = n/2+1;
            do
            {
                if (line == 1 || line == halfN || line == n)
                {
                    if (line == 1 || line == n)
                    {
                        Console.Write(new string('*', 2 * n));
                        Console.Write(new string(' ', n));
                        Console.Write(new string('*', 2 * n));
                        Console.WriteLine();
                        line++;
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', spaMid));
                        Console.Write("*");
                        Console.Write(new string('|', n));
                        Console.Write("*");
                        Console.Write(new string('/', spaMid));
                        Console.Write("*");
                        Console.WriteLine();
                        line++;
                    }
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', spaMid));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', spaMid));
                    Console.Write("*");
                    Console.WriteLine();
                    line++;
                }
            }
            while (line <= n);
        }
    }
}
