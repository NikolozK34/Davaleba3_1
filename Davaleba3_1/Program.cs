using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheiyvane ricxvi: ");

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < n+1; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"{n}-mde yvela naturalyri ricxvis jamia: {sum}");
        }
    }
}
