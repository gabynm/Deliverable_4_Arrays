/* Name: Gabriela Mejias
 * Date: February 9, 2023
 * Description: Create a C# console application that computes the first 25 numbers of the Fibonacci sequence
 */

namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            int n = 25;
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }

        }
    }
}