/* Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums
 * of digits, as well as to split them into triples with special properties. Help her to calculate very special
 * numbers called “nine-digit magic numbers”.
 * You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format 
 * abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff),
 * their sum of digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic numbers”.
 * Your task is to write a program to print these numbers in increasing order. */


using System;

namespace NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        private static bool NumberChek(int number)
        {
            string digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit < '1' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            int sum = Int32.Parse(Console.ReadLine());
            int diff = Int32.Parse(Console.ReadLine());
            int res = 0;
            for (int abc=111; abc<=777; abc++)
            {
                if (NumberChek(abc))
                {
                    int def = abc + diff;
                    if (NumberChek(def))
                    {
                        int ghi = def + diff;
                        if (NumberChek(ghi))
                        {
                            int tempSum = (abc / 100 % 10 + abc / 10 % 10 + abc % 10) + (def / 100 % 10 + def / 10 % 10 + def % 10) + (ghi / 100 % 10 + ghi / 10 % 10 + ghi % 10);
                            if (tempSum == sum)
                            {
                                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                res++;
                            }
                        }
                    }
                }
            }
            if (res == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
