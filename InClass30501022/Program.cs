/*
# Name:Leah Radcliffe
# email:radclilr@mail.uc.edu
# Assignment Title: In Class 10/22/2024
# Due Date:10/22/2024
# Course: IS 3050
# Semester/Year:Fall 2024
 * Description: Creating Methods, writting summaries, and connecting to the main
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass30501022
{
    internal class Program
    {
        static void Main(string[] args) //entry point
        {
            HelloWorld(); //"Call" or "invoke" the method
            //invoke the cube method
            Cube(42);   //invokes the method BUT discards what is returned
            int answer;
            answer = Cube(42); //invoke the value
            Console.WriteLine(answer);


            Console.WriteLine(checkEven(42));
            Console.WriteLine(checkEven(43));
            Console.WriteLine(checkEven(-1));
            Console.WriteLine(checkEven(-36));

            changeOrder(42);
            Console.WriteLine(changeOrder(43));
            Console.WriteLine(changeOrder(-25));
            Console.WriteLine(changeOrder(4));


        }

        /// <summary>
        /// Writes Hello World to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        /// <summary>
        /// Compute the cube of an integer
        /// </summary>
        /// <param name="num">The number to be cubed</param>
        /// <returns>The cube of num</returns>
        static int Cube(int num)
        {
            return num * num * num;
        }
        /// <summary>
        /// To Check if it is Even or Odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static Boolean checkEven(int number)
        {
            if (number % 2 == 0) { return true; }
            else { return false; }
        }
        /// <summary>
        /// To return false if the number is negative
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static Boolean changeOrder(int number)
        {
            if (number < 0) { return false; }
            else { return true; }
        }
    }
}
