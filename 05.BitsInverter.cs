/* Once Teodor played the following game: he started from a sequence of white and black balls and flipped 
 * the color of the 1st ball, then the color of the 4th ball, then the color of the 7th ball, etc. until
 * the last ball. Flipping was performed by replacing a black ball with a white ball and vice versa. Teodor 
 * was a smart mathematician so he wanted to generalize his game in a formal way. This is what he invented. 
 * You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also 
 * a number step. Write a program to invert the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output
 * as a sequence of bytes. 
 * Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1. */

using System;
using System.Collections;

namespace BitsInverter
{

    class BitsInverter
    {
        static string GetIntBinaryString(int num)
        {
            char[] b = new char[8];
            int pos = 7;
            int i = 0;

            while (i < 8)
            {
                if ((num & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
        static string BitFlipper(int step, string b)
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(b);
            for (int j = 0; j < b.Length; )
            {
                if (strBuilder[j] == '0')
                {
                    strBuilder[j] = '1';
                }
                else
                {
                    strBuilder[j] = '0';
                }
                j += step;
            }
            string str = strBuilder.ToString();
            return str;
        }
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int step = Int32.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            string b ="";
            for (int i = 0; i < n; i++)
            {
                numArray[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                b +=  GetIntBinaryString(numArray[i]);
            }
            string str = BitFlipper(step, b);
            char[] output = str.ToCharArray();
            string[] newNum = new string[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    newNum[i] += output[i * 8 + j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Convert.ToInt32(newNum[i], 2));
            }
        }
    }
}
