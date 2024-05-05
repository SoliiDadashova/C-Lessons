namespace Lesson3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BothEvenOrBothOdd
            //Console.WriteLine("Enter the  first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 <= 0 || num2 <= 0)
            //{
            //    Console.WriteLine("Cannot enter negative numbers.");
            //}
            //else
            //{
            //    if (num1 % 2 == 0 && num2 % 2 == 0)
            //    {
            //        Console.WriteLine("These numbers are even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("These numbers are not both even.");
            //    }

            #endregion
            #region StringContains
            //Console.WriteLine("Enter the first string: ");
            //string str1=Console.ReadLine();
            //Console.WriteLine("Enter the second string: ");
            //string str2=Console.ReadLine();
            //if(str1.Contains(str2))
            //{
            //    Console.WriteLine($"{str2} is found in the first string.");
            //}
            //else
            //{
            //    Console.WriteLine($"{str2} is not found the first string");
            //}
            #endregion
            #region Task3
            //Console.WriteLine("Enter the first number: ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int num2=int.Parse(Console.ReadLine());
            //double result =(double)num1 / num2; // Tam bölme işlemi için bir tamsayıyı double'a dönüştürüyoruz
            //Console.WriteLine($"Result: {result}");
            #endregion
            #region Conversions
            /*Console.WriteLine("Enter the integer number: ");
            int num1=int.Parse(Console.ReadLine());
            double num2 = num1;//Implicit Conversion 
            Console.WriteLine("The converted double value: "+ num2);*/

            /*Console.WriteLine("Enter the number: ");
            double num1=double.Parse(Console.ReadLine());   
            int num2=(int)num1;//Explicit Conversion
            Console.WriteLine("The converted int value: " + num2);*/

            /*int intValue = 42;
            object boxedValue = intValue; // Boxing
            int unboxedValue = (int)boxedValue; // Unboxing
            Console.WriteLine("Boxed value: " + boxedValue);
            Console.WriteLine("Unboxed value: " + unboxedValue);*/
            #endregion
            #region OperatorOverload
            /*ComplexNumber cn1 = new ComplexNumber(1, 7);
            ComplexNumber cn2= new ComplexNumber(3, 4);
            ComplexNumber sum = cn1 + cn2;
            Console.WriteLine($"resultOfAddition: {sum.Real} and {sum.Imaginary}");*/
            #endregion


        }
        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }
            public ComplexNumber(double real,double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
           public static ComplexNumber operator+(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }
        }
    }
}