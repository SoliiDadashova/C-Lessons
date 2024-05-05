namespace Lesson2Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Taks1
            /* Console.WriteLine("Please enter the letters: ");
             var input=Console.ReadLine();
             if(input.Length!=3)
             {
                 Console.WriteLine("Please enter 3 letters: ");
                 return;
             }
             char[]arrays = input.ToCharArray();
             Array.Reverse(arrays);
             Console.WriteLine(arrays);*/
            #endregion
            #region Task2
            /*Console.WriteLine("Please enter name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Please enter surname: ");
            string surname=Console.ReadLine();
            string fullName = name.ToUpper() + " " + surname.ToUpper();
            Console.WriteLine(fullName);*/
            #endregion
            #region Task3
            /*Console.WriteLine("Please enter the radius: ");
           double radius = double.Parse(Console.ReadLine());
           if (radius < 0)
           {
               Console.WriteLine("Radius can not be negative");
               return;
           }
           double periMeter = 2 * Math.PI * radius;
           double area = Math.PI * radius * radius;
           Console.WriteLine("Perimeter is:  " + periMeter);
           Console.WriteLine("Area is: " + area);*/
            #endregion
            #region Task4
            /*Console.WriteLine("Enter the word");
            string input=Console.ReadLine();
            string normalizedInput=input.ToLower();
            char[] arrays = input.ToCharArray();
            Array.Reverse(arrays);
            for (int i = 0; i < normalizedInput.Length; i++)
            {
                if (normalizedInput[i] != arrays[i])
                {
                    Console.WriteLine("This word is not polindrome");
                    return;
                }
            }
            Console.WriteLine("This word is polindorme");*/
            #endregion
            #region Task5
            /*Console.WriteLine("Enter the integer: ");
           int number = int.Parse(Console.ReadLine());

           for (int i = 2; i < number; i++)
           {
               if (number % i == 0)
               {
                   Console.WriteLine("This number is not prime");
                   return;
               }
           }
           Console.WriteLine("This number is prime");*/
            #endregion
            #region Task6
            //Console.WriteLine("Enter the first word: ");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Enter the second word: ");
            //string str2 = Console.ReadLine();

            //char[] arry1 = str1.ToLower().ToCharArray();
            //char[] arry2 = str2.ToLower().ToCharArray();
            //Array.Sort(arry1);
            //Array.Sort(arry2);

            //if (arry1.Length != arry2.Length)
            //{
            //    Console.WriteLine("This word is not anagram");
            //}
            //else
            //{
            //    string newStr1 = new string(arry1);
            //    string newStr2 = new string(arry2);
            //    if (newStr1 == newStr2)
            //    {
            //        Console.WriteLine("This word is anagram");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This word is not anagram");
            //    }
            //}
            #endregion
            #region Task7
            //int count = 0;
            //Console.WriteLine("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prime numbers between " + num1 + " and " + num2 + ":");
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task8
            /*int charCount = 0;
            int digitCouunt = 0;
            Console.WriteLine("Enter the string: ");
            string input=Console.ReadLine();
            char[] arry = input.ToCharArray();
            foreach(char c in arry)
            {
                if (char.IsDigit(c))
                {
                    digitCouunt++;
                }
                else if(char.IsLetter(c))
                {
                    charCount++;
                }
            }
            Console.WriteLine("Number of letters: " + charCount);
            Console.WriteLine("Number of digits: " + digitCouunt);*/
            #endregion

        }
        //static bool IsPrime(int number)
        //{
        //    int count = 0;
        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}