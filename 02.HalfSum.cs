/* Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game.
 * He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums
 * the left and right sub-sums, and compares the sub-sums. Please help him.
 * You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is
 * equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum.
 * In case of no, print also the difference between the left and the right sums. */

using System;

namespace HalfSum
{
    class HalfSum
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int firstSumOfNums = 0;
            int secondSumOfNums = 0;
            for (int i = 0; i < n; i++)
            {
                int firstN = Int32.Parse(Console.ReadLine());
                firstSumOfNums = firstN + firstSumOfNums;
            }
            for (int i = 0; i < n; i++)
            {
                int secondN = Int32.Parse(Console.ReadLine());
                secondSumOfNums = secondN + secondSumOfNums;
            }
            int diff = Math.Abs(firstSumOfNums-secondSumOfNums);
            if (diff == 0)
            {
                int s = firstSumOfNums;
                Console.WriteLine("Yes, sum={0}", firstSumOfNums);
            }
            else
            {

                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}