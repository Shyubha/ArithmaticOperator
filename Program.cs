using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_ArithmaticOperator_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

        start:
            Console.WriteLine("Enter First NUMBER");
            int No1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second NUMBER");
            int No2 = Convert.ToInt32(Console.ReadLine());

            int result = No1 + No2;
            Console.WriteLine("Addition of two No's is" + result);

            int result1 = No1 - No2;
            Console.WriteLine("Substraction of two No's is" + result1);

            int result2 = No1 * No2;
            Console.WriteLine("Multiplication of two No's is" + result2);

            int result3 = No1 / No2;
            Console.WriteLine("Division of two No's is" + result3);

            Console.ReadLine();
            goto start;







        }
    }
}