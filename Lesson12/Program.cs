
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Lesson12
{
    public class Program
    {
        const string myPath = @"C:\\Users\\compo\\Desktop\\C#Lessons";
        const string myFile = "Student";
        static void Main(string[] args)
        {

            //CreateDirectory
            /*string BaseFolderPath = @"C:\\Users\\compo\\Desktop\\C#Lessons";
            string newFolderName = "Students";
            string newFolderPath=Path.Combine(BaseFolderPath, newFolderName);
            if(!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("Directory has created: " + newFolderPath);

            }
            else
            {
                Console.WriteLine("The directory has already exists: ");
            }*/
            //DeleteDirectory
            /*string path = @"C:\Users\compo\Desktop\C#Lessons\Students";
            if(Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Directory has deleted:");
            }
            else
            {
                Console.WriteLine("Directory has not found:");
            }*/
            Console.WriteLine("What do you want to do? \r\n" +
                "1-Create Student\r\n" +
                "2-The List of All Students\r\n" +
                "3-Update Student\r\n" +
                "4-Delete Student\r\n");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var student = RegistrStudent();
                    AddStudentToFile(student);
                    break;

                case 2:
                    var students = ListOfAllStudents();
                    PrintListOfStudents(students);

                    break;
                case 3:
                    Console.WriteLine("Please enter the ID: ");
                    var id = Guid.Parse(Console.ReadLine());
                    UpdateStudent(id);
                    break;
                case 4:
                    Console.WriteLine("Please enter the ID:");
                    var deletedID = Guid.Parse(Console.ReadLine());
                    DeleteStundet(deletedID); ;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
        public static Student RegistrStudent()
        {
            Console.WriteLine("Registering Student: \r\n");
            Console.WriteLine("Please enter the name: ");
            var student = new Student();
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            student.Age = int.Parse(Console.ReadLine());
            student.ID = Guid.NewGuid();
            return student;

        }
        public static void AddStudentToFile(Student student)
        {
            var studentDatas = $"Name: {student.Name}\r\n" +
                $"Surname: {student.Surname}\r\n" +
                $"Age: {student.Age}\r\n" +
                $"ID: {student.ID}";

            string newFolderPath = Path.Combine(myPath, myFile);
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
            }
            string fileName = $"{student.ID}.txt";
            string filePath = Path.Combine(newFolderPath, fileName);
            if (File.Exists(filePath))
            {
                Console.WriteLine("This student has already registered:");
            }
            else
            {
                File.WriteAllText(filePath, studentDatas);
                Console.WriteLine("Student added succesfully");

            }

        }
        public static List<Student> ListOfAllStudents()
        {
            var newFolderPath = Path.Combine(myPath, myFile);
            var studnets = new List<Student>();
            if (Directory.Exists(newFolderPath))
            {
                var files = Directory.GetFiles(newFolderPath, "*.txt");
                foreach (var file in files)
                {
                    var student = new Student();
                    var lines = File.ReadAllLines(file);
                    student.Name = lines[0].Split(":")[1].Trim();
                    student.Surname = lines[1].Split(":")[1].Trim();
                    student.Age = int.Parse(lines[2].Split(":")[1].Trim());
                    studnets.Add(student);
                }
            }
            return studnets;

        }
        public static void PrintListOfStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student Information:");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Surname: {student.Surname}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine(new string('-', 20)); //20 dene xet qoyur
            }
        }
        public static void UpdateStudent(Guid id)
        {
            string newFolderPath = Path.Combine(myPath, myFile);
            string fileName = $"{id}.txt";
            string filePath = Path.Combine(newFolderPath, fileName);
            if (File.Exists(filePath))
            {
                var newStudent = new Student();
                Console.WriteLine("Updating student: \r\n");
                Console.WriteLine("Please enter the new name: ");
                newStudent.Name = Console.ReadLine();
                Console.WriteLine("Please enter the new surname: ");
                newStudent.Surname = Console.ReadLine();
                Console.WriteLine("Please enter the new age: ");
                newStudent.Age = int.Parse(Console.ReadLine());
                newStudent.ID = id;
                var studentData = $"Name: {newStudent.Name}\r\n" +
                    $"Surname: {newStudent.Surname}\r\n" +
                    $"Age: {newStudent.Age}\r\n" +
                    $"ID: {newStudent.ID}";
                File.WriteAllText(filePath, studentData);
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not find");
            }

        }
        public static void DeleteStundet(Guid id)
        {
            string newFolderPath = Path.Combine(myPath, myFile);
            string fileName = $"{id}.txt";
            string filePath = Path.Combine(newFolderPath, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("The studnet deleted succesfully:");
            }
            else
            {
                Console.WriteLine("The sudent not foud");
            }
        }
        public class Student
        {
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }
    }
    public class App
    {
        const string myPath = @"C:\Users\compo\Desktop\C#Lessons";
        const string myFile = "Book";
        static void Main(string[] args)
        {

            var book = AddBook();
            WriteBookToFile(book);


        }
        public static Book AddBook()
        {
            var book = new Book();
            Console.WriteLine("Please enter the book's name: ");
            book.Name = Console.ReadLine();
            Console.WriteLine("Please enter the book's author: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Please enter the ISBN: ");
            book.ISBN = Console.ReadLine();
            Console.WriteLine("Please enter the genre of book: ");
            book.Genre = Console.ReadLine();
            Console.WriteLine("Have you read this book?: Please write Yes Or No");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                book.IsRead = true;
            }
            else if (input == "no")
            {
                book.IsRead = false;
            }
            else
            {
                Console.WriteLine("Please enter correctly");
            }
            Console.WriteLine("Is this book a favorite?");
            string input2 = Console.ReadLine().ToLower();
            if (input2 == "yes")
            {
                book.IsFavorite = true;
            }
            else if (input2 == "no")
            {
                book.IsFavorite = false;
            }
            else
            {
                Console.WriteLine("Please enter correctly");

            }
            book.ID = Guid.NewGuid();
            return book;


        }
        public static void WriteBookToFile(Book book)
        {

            var bookDatas = $"Book's name: {book.Name}\r\n" +
                $"Book's Author: {book.Author}\r\n" +
                $"Book's Genre: {book.Genre}\r\n" +
                $"Book's ID: {book.ID}\r\n" +
                $"IsRead: {book.IsRead}\r\n" +
                $"IsFavorite: {book.IsFavorite}\r\n" +
                $"ISBN: {book.ISBN}";
            string newFolder = Path.Combine(myPath, myFile);
            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
            }
            string path = $"{book.ID}.txt";
            string filePath = Path.Combine(newFolder, path);
            if (File.Exists(filePath))
            {
                Console.WriteLine("This book has already exist:");
            }
            File.WriteAllText(filePath, bookDatas);
            Console.WriteLine("The book has been successfully written to the file");

        }
    }
    public class Book
    {
        public Guid ID { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public bool IsFavorite { get; set; }

    }
}