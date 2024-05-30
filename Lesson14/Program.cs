using Lesson14.CustomException;

namespace Lesson14
{
    internal class Program
    {
        const string myFilePath = @"C:\Users\compo\Desktop\C#Lessons\Lesson14";
        const string filePath = "Log.txt";
        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number please: ");
                    int num=int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("This number is even");
                    }
                    else
                    {
                        Console.WriteLine("This number is odd");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you entered is too large or too small. Please enter a valid number.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    break;
                }

            }
            //CustimException
            /*List<Student>students= new List<Student>();
            try
            {
                Student.Add(students, "SOlmaz", 19);
                Student.Add(students, "ALmaz", -5);
                foreach(var s in students)
                {
                    Console.WriteLine($"Name is: {s.Name}\r\n" +
                        $"Age is: {s.Age}");
                    Console.WriteLine("--------------------------");
                }
            }
            catch (InvalidStudentException ex)
            {
                Console.WriteLine($"Failed to add student: {ex.Message}");
            }*/

            //FormatException
            /* try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ENter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException ex)
            {
                LogException(ex.Message);
                Console.WriteLine("Exception: " + ex.Message);
            }
            catch (FormatException ex)
            {
                LogException(ex.Message);
                Console.WriteLine("Format exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }*/

            //IndexOutOfRangeException
            /*try
            {
                int[] arr = new int[4];
                Console.WriteLine(arr[6]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception is: {ex.Message}");
            }*/

            /*try
            {
                CheckAge(16);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/



        }
        public static void LogException(string message)
        {
            string lofFilePath = Path.Combine(myFilePath, filePath);
            //File.AppendAllLines
            using (StreamWriter sw = new StreamWriter(lofFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss")}: {message}\r\n");
            }
        }
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Age must be 18 or older");
            }
            else
            {
                Console.WriteLine("Succesfully");
            }

        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new CustomException.InvalidStudentException("Name cannot be null or empty.");
            }
            if (age < 18)
            {
                throw new CustomException.InvalidStudentException("Age should be older than 18.");
            }
            Name = name;
            Age = age;
        }
        public static void Add(List<Student> students,string name,int age)
        {
            try
            {
                Student student = new Student(name, age);
                students.Add(student);
            }
            catch (CustomException.InvalidStudentException ex)
            {
                Console.WriteLine($"Failed to add student: {ex.Message}");
            }
        }

    }
}