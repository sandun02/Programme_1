using System;

namespace Programme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //print hello world.
            Console.WriteLine("MY First V.S.Programme!!");
            Console.WriteLine("Hi Sandun !!");/* print sandun */

            //Data Types

            /*Data Type     Size in Bytes       Description
              
              int           4                   To store counting numbers
              float         4                   Single precision floating point numbers
              double        8                   Double precision floating point numbers
              char          2                   To store a single character
              string        20+                 To store a sequence of characters
              bool          1                   To store boolean True or False       */

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); 
            //1.Write a C# programme to add two numbers and display the answer.

            int num1;
            int num2;
            int ans;

            num1 = 24;
            num2 = 45;

            ans = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + ans);
            
            //Console.ReadLine();

            //2.Write a C# programme to accept two numbers as user input and display the addition,
            //subtraction,multiplication and division of the numbers.

            Console.WriteLine("Please Enter the First Number....:-");
            string number1 = Console.ReadLine();
            double Num1 = Convert.ToDouble(number1);

            Console.WriteLine("Please Enter the Second Number....:-");
            string number2 = Console.ReadLine();
            double Num2 = Convert.ToDouble(number2);

            //Addition
            double sum = Num1 + Num2;
            Console.WriteLine("Addition is : " + sum);

            //Subtraction
            double sub = Num1 - Num2;
            Console.WriteLine("Subtraction is : " + sub);

            //Multiplication
            double mul = Num1 * Num2;
            Console.WriteLine("Multiplication is : " + mul);

            //Division
            double div = Num1 / Num2;
            Console.WriteLine("Division is : " + div);


            Console.ReadLine();

            //1-4 Videos



            
              
        }
    }
}
