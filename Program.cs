using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.Write("Enter Starting Number : ");

            start = int.Parse(Console.ReadLine());

            Console.Write("Enter Ending Number : ");

            end = int.Parse(Console.ReadLine());

            Console.Write("The perfect numbers between " + start + " and " + end + " are : \n ");

            for (int i = start; i <= end; i++)

            {

                double sum = 0;

                for (int j = 1; j < i; j++)

                {

                    if (i % j == 0)

                        sum = sum + j;

                }

                if (sum == i)

                    Console.Write("\n {0} \n " , i );
            }

            Console.WriteLine();
        }
    }
}
