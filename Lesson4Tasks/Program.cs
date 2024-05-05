using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime 
            /*Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);

            Console.WriteLine(new DateTime(2023, 4, 15, 10, 30, 0));
            Console.WriteLine(DateTime.Now.ToString("MM.dd.yyyy   HH:mm:ss"));*/

            //TimeSpan
            /*TimeSpan time = new TimeSpan(3, 2, 11, 3, 21);
            Console.WriteLine(time);

            TimeSpan time1 = TimeSpan.FromDays(5);
            TimeSpan time2 = TimeSpan.FromHours(2);
            TimeSpan time3 = TimeSpan.FromMinutes(4);
            TimeSpan time4 = TimeSpan.FromSeconds(6);
            TimeSpan time5 = TimeSpan.FromMilliseconds(7);
            TimeSpan time6 = TimeSpan.FromTicks(10);

            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);

            TimeSpan time7 = time1.Add(time2).Add(time3).Add(time4).Add(time5).Add(time6);


            Console.WriteLine(time7);
            TimeSpan time1 = TimeSpan.FromDays(5);
            TimeSpan time2 = TimeSpan.FromMinutes(4);
            TimeSpan time3 = time1.Subtract(time2);
            Console.WriteLine(time3);*/

            //Tasks About DateTime and TimeSpan

            /*Console.WriteLine("Enter the date(dd.MM.yyyy): ");
            string dateInput = Console.ReadLine();

            DateTime date;

            if (!DateTime.TryParseExact(dateInput, "dd.MM.yyyy",  null, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Invalid date format! Please enter a date in the format MM.dd.yyyy.");
                return;
            }
            Console.WriteLine("ENter the day : ");
            int day=int.Parse(Console.ReadLine());
            DateTime newDate = date.AddDays(-day);

            // new date 
            Console.WriteLine($"{day} Date 65 days ago: {newDate:dd.MM.yyyy}");*/


            /*Console.WriteLine("Emter the start date: ");
            string startDateInput = Console.ReadLine();
            Console.WriteLine("Enter the end date: ");
            string endDateInput = Console.ReadLine();
            DateTime startDate, endDate;

            if (!DateTime.TryParseExact(startDateInput,"dd.MM.yyyy",null,DateTimeStyles.None, out startDate) ||
            !DateTime.TryParseExact(endDateInput, "dd.MM.yyyy", null, DateTimeStyles.None, out endDate))
            {
                Console.WriteLine("Invalid date format!");
                return;
            }
            TimeSpan difference = endDate - startDate;
            int totalDays = (int)difference.TotalDays;
            int totalWeeks = totalDays / 7;
            Console.WriteLine($"Total weeks are: {totalWeeks}");*/


            /*Console.WriteLine("Enter the start day: ");
            string startInputDate=Console.ReadLine();
            Console.WriteLine("Enter the end day: ");
            string endInputDate = Console.ReadLine();
            DateTime startDate, endDate;
            if (!DateTime.TryParseExact(startInputDate, "dd.MM.yyyy", null, DateTimeStyles.None, out startDate) ||
               !DateTime.TryParseExact(endInputDate, "dd.MM.yyyy", null, DateTimeStyles.None, out endDate))
               {
                Console.WriteLine("Format is wrong. Please enter correct format: ");
                return;
               }
            if(startDate > endDate)
            {
                Console.WriteLine("Start date cannot be after end date!");
                return;

            }

            TimeSpan diffrence=endDate - startDate;
            int days=(int)diffrence.TotalDays;
            Console.WriteLine($"Diffrence is: {days}");*/

            /*Console.WriteLine("Enter the date: ");
            string dateInput=Console.ReadLine();
            DateTime date;
            if(!DateTime.TryParseExact(dateInput,"dd.MM.yyyy",null,DateTimeStyles.None,out date))
            {
                Console.WriteLine("Can not input this format ");
                return;
            }
            DayOfWeek dayOfWeek = date.DayOfWeek;
            Console.WriteLine($"The day of the week is: {dayOfWeek}");*/

            /*Console.WriteLine("Enter your birhday: ");
            string bdayInput=Console.ReadLine();
            DateTime bDay;
            if(!DateTime.TryParseExact(bdayInput,"dd.MM.yyyy",null,DateTimeStyles.None, out bDay))
            {
                Console.WriteLine("Please enter the righ format");
                return;
            }
            DayOfWeek yourBirhDayWeek = bDay.DayOfWeek;
            Console.WriteLine($"Your birhday week is: {yourBirhDayWeek}");*/

            /*Console.WriteLine("Enter your birhday: ");
            string bdayInput = Console.ReadLine();
            DateTime bDay;
            if (!DateTime.TryParseExact(bdayInput, "dd.MM.yyyy", null, DateTimeStyles.None, out bDay))
            {
                Console.WriteLine("Please enter the righ format");
                return;
            }
            DateTime nowDate = DateTime.Now.Date;
            TimeSpan currentDayOfLife=nowDate-bDay;
            int totalDays = (int)currentDayOfLife.TotalDays;
            Console.WriteLine($"You have lived {totalDays} days");*/

            /*DateTime nowDate = DateTime.Now.Date;
            DateTime addDays= nowDate.AddDays(40);
            DayOfWeek dayOfWeek=addDays.DayOfWeek;
            Console.WriteLine($"After 40 days from today, it will be {dayOfWeek}.");*/

            /*Console.WriteLine("Enter the day: ");
            string dayInput = Console.ReadLine();
            Console.WriteLine("Enter the month:");
            string monthInput = Console.ReadLine();
            Console.WriteLine("ENter the year: ");
            string yearInput = Console.ReadLine();
            int day, month, year;
            DateTime currentDate = DateTime.Now.Date;
            if (!DateTime.TryParseExact(dayInput, "dd", null, DateTimeStyles.None, out DateTime tempDay) ||
                    !DateTime.TryParseExact(monthInput, "MM", null, DateTimeStyles.None, out DateTime tempMonth) ||
                    !DateTime.TryParseExact(yearInput, "yyyy", null, DateTimeStyles.None, out DateTime tempYear))
            {
                Console.WriteLine("Format is not correct:");
                return;
            }
            day = tempDay.Day;
            month = tempMonth.Month;
            year = tempYear.Year;
            if (day == currentDate.Day && month == currentDate.Month && year == currentDate.Year)
            {
                Console.WriteLine("The given date is the current date.");
            }
            else
            {
                Console.WriteLine("The given date is not the current date.");
            }*/

            /*Console.WriteLine("Enter the day of week: ");
            int day=int.Parse(Console.ReadLine());
            if (day <= 0 || day > 7)
            {
                Console.WriteLine("Invalid day number.PLease enter 1-7");
            }
            DayOfWeek dayOfWeek = (DayOfWeek)day;
            Console.WriteLine($"The {day}. day is: {dayOfWeek}");*/


            ////Arrays

            /* Console.WriteLine("Please write length of the array: ");
             int length = int.Parse(Console.ReadLine());
             int[] arry = new int[length];
             int sum = 0;


             for (int i = 0; i < arry.Length; i++)
             {
                 Console.WriteLine($"Please enter {i + 1}. element of the array: ");
                 arry[i] = int.Parse(Console.ReadLine());
                 sum += arry[i]; // Add the array element to the sum
             }

             Console.WriteLine($"Sum of the array elements: {sum}");

             Console.WriteLine("Your array's elements are: ");
             foreach (int num in arry)
             {
                 Console.Write(num + " ");
             }*/

            /*Console.WriteLine("Please enter the legth of array: ");
            int length=int.Parse(Console.ReadLine());
            int[]myArray= new int[length];
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Please enter the {i+1}. element: ");
                myArray[i]=Convert.ToInt32(Console.ReadLine());
                sum += myArray[i];
            }
            double average = (double)sum / myArray.Length;
            Console.WriteLine($"The avarage of elements is: {average}");*/

            /*Console.WriteLine("Enter the length of array: ");
            int length=int.Parse(Console.ReadLine());   
            int[] myArray=new int[length];
  
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Please enter the {i+1}.element: ");
                myArray[i]=int.Parse(Console.ReadLine());
            }
            int maxValue = myArray[0];
            int minValue = myArray[0];
            for (int i=1; i < length; i++)
            {
                if (myArray[i]>maxValue)
                {
                    maxValue = myArray[i];
                }
                if (myArray[i]<minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine($"The max value of array is: {maxValue}");
            Console.WriteLine($"The min value of array is: {minValue}");*/

            /*int[] arry = { 1, 2, 3, 4, 5 };
            int[] reversearry = new int[arry.Length];

            for (int i = 0, j = arry.Length - 1; i < arry.Length; i++, j--)
            {
                reversearry[i] = arry[j];
            }

            foreach (var element in reversearry)
            {
                Console.WriteLine(element);
            }
            //Array.Reverse(myArray)

            //foreach (var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}*/

            /*int[] myArray = new int[4] { 11, 11, 22, 22 };
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        Console.WriteLine("repeating element: " + myArray[i]);
                        break;
                    }
                }
            }*/

            /*Console.WriteLine("ENter the first number: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("ENter the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            int maxValue;
            if (num1 >= num2 && num1 >= num3)
            {
                maxValue = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
                maxValue = num2;
            else
                maxValue = num3;
            Console.WriteLine($"The max value is: {maxValue}");*/


            /*Console.WriteLine("Enter the first number: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2=int.Parse(Console.ReadLine());

            Console.WriteLine("Here are the options");
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");

            Console.WriteLine();
            Console.WriteLine("Enter your choise: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = Calculate(num1, num2, choice);
            Console.WriteLine($"Result is: {result}");*/

            /*Console.WriteLine("Enter your grade: ");
            int grade=int.Parse(Console.ReadLine());
            if (grade>=90&&grade<=100)
            {
                Console.WriteLine("Your note is A: ");
            }
            else if(grade>=80 && grade <= 89)
            {
                Console.WriteLine("Your note is B:");
            }*/

        }
        public static double Calculate(int num1, int num2, int choise)
        {
            switch (choise)
            {
                case 1:
                    return num1 + num2;
                case 2:
                    return num1 - num2;
                case 3:
                    return num1 * num2;
                case 4:
                    if (num2 != 0)
                        return num1 / (double)num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        break;
                    }
                case 5:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            return 0;

        }
    }
}