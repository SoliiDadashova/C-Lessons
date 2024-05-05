using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson5Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2
            /*int sum = 0;
            for (int i = 0; i <=20; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);*/
            //Task3           
            /*int[]myArray=new int[5];
            int sum = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Please enter the {i+1}. element: ");
                myArray[i]=int.Parse(Console.ReadLine());
                sum += myArray[i];
            }
            double avarage=(double)sum/myArray.Length;
            Console.WriteLine($"The sum of the numbers are: {sum} ");
            Console.WriteLine($"The avareh of numbers are: {avarage}");*/
            //Task4
            /* Console.WriteLine("Input upto the table number starting from 1: ");
             int n = int.Parse(Console.ReadLine());

             for (int i = 1; i <= 10; i++)
             {
                 for (int j = 1; j <= n; j++)
                 {
                     Console.Write($"{j}x{i}={i * j}");
                     Console.WriteLine();
                 }
             }*/
            //Task5
            /* Console.WriteLine("Enter the number of rows:");
             int rows = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= rows; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/

            //Task6
            /* Console.WriteLine("Enter the rows: ");
             int number = 1;
             int rows=int.Parse(Console.ReadLine()); 

             for(int i=1; i<=rows; i++)
             {
                 for(int j=1; j<=i; j++)
                 {
                     Console.Write(number + " ");
                     number++;
                 }
                 Console.WriteLine();

             }*/
            //Task7
            /*Console.WriteLine("Input the number or terms: ");
            int input=int.Parse(Console.ReadLine());

            long sum = 0;
            long longNumber = 9;

            for (int i = 0; i <input; i++)
            {
                Console.Write(longNumber+" "); 
                sum += longNumber;
                longNumber = longNumber*10+9;
            }
            Console.WriteLine($"\nThe sum of this series is: {sum}");*/
            //Task9
            /*Console.WriteLine("Enter the number: ");
            int input=int.Parse(Console.ReadLine());

            bool IsPrime = true;

            for (int i = 2; i <= input; i++)
            {
                for (int j = 2; j <i; j++)
                {
                    if  (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write(i + " ");
                }
            }*/
            //Task10
            /*Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome number.");
            }*/


            /*Console.WriteLine("Enter the input: ");
            int input=int.Parse(Console.ReadLine());
            char[]array=input.ToString().ToCharArray();
            Array.Reverse(array);
            string reversedNumber = new string(array);
            if(input.ToString()==reversedNumber)
            {
                Console.WriteLine("This number is palinrome: ");
            }
            else
            {
                Console.WriteLine("This number is not palindrime: ");
            }*/

        }
        public static bool IsPalindrome(int number)
        {
            int originalNumber=number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }
            return originalNumber == reversedNumber;
        }
    }

 }