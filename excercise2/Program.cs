using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print prompt to input loan amt
            Console.WriteLine("What is principal amount of the loan in dollars?");
            //collect user input for loan
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            //print prompt to input interest
            Console.WriteLine("What is interest rate (input 0.85 for 5%)?");
            //collect user input for rate
            double rate = Convert.ToDouble(Console.ReadLine());
            //print prompt to input a period
            Console.WriteLine("What is period of loan in years?");
            //collect user input for period
            int period = Convert.ToInt32(Console.ReadLine());
            //calc interest
            double interest = loanAmount * rate * period;
            //display interest
            Console.WriteLine("Total interest: "+ interest);
            //wait for user input
            Console.ReadKey();
        }
    }
}
