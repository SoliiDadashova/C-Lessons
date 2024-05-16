using ClassesAndInheritance.MyRestaurant;
using System.Drawing;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace ClassesAndInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*int[,] array = new int[2, 3] { { 1, 2, 4 }, { 5, 6, 7 } };
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine(sum);*/

            /*int[,] array = { {1,2,4 }, { 3,5,6} };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] +"    ");
                }
                Console.WriteLine();
            }*/

            /*int[] scores = { 90, 85, 95, 70, 80 };
            Student student = new Student("Solmaz","Dadashova",1,scores);
            student.printPerson();
            Console.WriteLine("Grade: " + student.Calculate());*/

            /*Rectangle rectangle = new Rectangle(12,34);
           var pm= rectangle.CalculatePerimeter();
           var area= rectangle.CalculateArea();
            Console.WriteLine($"The perimeter of rectangle is: {pm} and area is: {area}");*/

            /*Circle circle= new Circle();
            circle.Radius = 5;
            var circumference= circle.CalculateCircumference();
            var area=circle.CalculateArea();
            Console.WriteLine($"The area of circle is: {area} and the circumference is: {circumference} ");*/

            /*Car car = new Car("Kio", "Rio", 2016);
            car.Accelerate(100);
            Console.WriteLine(car.Speed);
            car.Decelerate(10);
            Console.WriteLine(car.Speed);*/

            /*Employee employee = new Employee("Solmaz", "Dadashova", "Credit", "Manager", 2000, 8);
            employee.IncreaseSalary();*/

            /*Library library=new Library();
            Book b1 = new Book("Harry Potter", "J. K. Rowling","QANUN", "9786053327983");
            library.AddBook(b1);
            Book b2 = new Book("Les Miserables", "Victor Hugo", "QANUN", "9786053756838");
            library.AddBook(b2);
            library.RemoveBook("9786053756838");
            library.GetAllBooks();*/

            /*Bank bank = new Bank("Solmaz Dadashova", "1535272883", 2500);
            bank.Deposit(1000);
            bank.Withdraw(100);
            bank.CheckBalance();*/

            /*List<int>arr = new List<int>() {1,1,0,-1,-1 };
            int positiveCount = 0;
            int negativeCount=0;
            int zeroCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
                else if (arr[i] >0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            double rotiosPozitive = (double)positiveCount / arr.Count;
            double rotiosNegative= (double)negativeCount / arr.Count;
            double rotiosZero= (double)zeroCount / arr.Count;
            Console.WriteLine($" {rotiosNegative:F6}");*/

            /*List<int> candles = new List<int>() { 3, 2,1, 3 };
            int maxElement = candles[0];
            int maxElementCount = 1;
            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > maxElement)
                {
                    maxElement = candles[i];
                    maxElementCount = 1; 
                }
                else if (candles[i] == maxElement)
                {
                    maxElementCount++;
                }
            }

            Console.WriteLine(maxElementCount);*/

            /*//string s = "07:05:45PM";
            //var convertedTime =  DateTime.ParseExact(s,"hh:mm:ss",CultureInfo.InvariantCulture);*/

            /*int size = 20;
            for (int i = 1; i <= size; i++)
            {
                // add spaces
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                // add #
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }

                //for move to nxt line
                Console.WriteLine();
            }*/

            /* Personn[] persons = new Personn[3];
             for (int i = 0; i < persons.Length; i++)
             {
                 persons[i] = new Personn()
                 {
                     Name = Console.ReadLine()
                 };
             }
             foreach (Personn person in persons)
             {
                 Console.WriteLine(person.ToString());
             }*/

            /*Personn p=new Personn();
            p.Greet();
            Studentt student = new Studentt();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();
            Teacher teacher = new Teacher();
            teacher.SetAge(40);
            teacher.Greet();
            teacher.Explain();*/

            /*PhotoBook book1= new PhotoBook();
            Console.WriteLine(book1.GetNumberPages());
            PhotoBook book2= new PhotoBook(24);
            Console.WriteLine(book2.GetNumberPages());
            BigPhotoBook bigPhotoBook1= new BigPhotoBook();
            Console.WriteLine(bigPhotoBook1.GetNumberPages());*/

            /* Person[] persons = new Person[3];
             for (int i = 0; i < 3; i++)
             {
                 if (i == 0)
                 {
                     persons[i] = new Teacher(Console.ReadLine());
                 }
                 else
                 {
                     persons[i] = new Student(Console.ReadLine());
                 }
             }
             for (int i = 0; i < 3; i++)
             {
                 if (i == 0)
                 {
                     ((Teacher)persons[i]).Explain();

                 }
                 else
                 {
                     ((Student)persons[i]).Study();
                 }
             }*/

            /*Electronic electronic = new Electronic("Blender",0,322.9);
            electronic.StockStatusCheck();*/

            /*Restaurant restaurant = new Restaurant();
            restaurant.AddMenuItem("Pasta", 22, 30.9);
            restaurant.AddMenuItem("Chicken", 12, 40);
            restaurant.ShowMenu();
            restaurant.PlaceOrder("Pasta", 2);
            restaurant.PlaceOrder("Chicken", 14);
            restaurant.ShowOrder();*/

            /*Random rnd = new Random();
            var vinNum=rnd.Next(0,100);
            bool IsWin = false;
           
            while(!IsWin)
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                int n = int.Parse(Console.ReadLine());
                if (vinNum>n)
                {
                    Console.WriteLine("Plase enter a higher number: ");
                }
                else if (vinNum < n)
                {
                    Console.WriteLine("Plase enter a smaller number: ");
                }
                else if(vinNum== n)
                {
                    Console.WriteLine("YOU WINNN.");
                        IsWin=true; 
                }
                Console.WriteLine();
            }*/


            
        }
    }
  

    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double ProductPrice { get; set; }
        public Product(string name,int stock, double productPrice)
        {
            Name = name;
            Stock = stock;
            ProductPrice = productPrice;

        }
        public void StockStatusCheck()
        {
            if(Stock<=0)
            {
                Console.WriteLine("This product is out of stock");
            }
            else
            {
                Console.WriteLine($"{Name} stock is {Stock}");
            }

        }
    }
    public class Electronic : Product
    {
        public Electronic(string name, int stock,double productPrice) : base(name, stock,productPrice)
        {
        }
    }
    public class Clothes : Product
    {
        public Clothes(string name, int stock, double productPrice) : base(name, stock, productPrice)
        {
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }
        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name):base(name)
        {
            
        }
        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }

    public class PhotoBook
    {
        protected int NumPages { get; set; }
        public PhotoBook()
        {
            NumPages = 16;
        }
        public PhotoBook(int numPages)
        {
            NumPages = numPages;
        }
        public int GetNumberPages()
        {
            return NumPages;
        }
    }
    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            NumPages = 64;
        }

    }
    public class Personn
    {
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int age)
        {
            Age= age;
        }

    }
    public class Studentt:Personn
    {
        public void Study()
        {
            Console.WriteLine("I'm studying"); 
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age} years old");
        }
    }
    //public class Teacher : Personn
    //{
    //    public void Explain()
    //    {
    //        Console.WriteLine("I'm explaining");
    //    }
    //}
    //public class Person
    //{
    //    protected string FirstName;
    //    protected string LastName;
    //    protected int Id;

    //    public Person(string firtsName, string lastName, int id)
    //    {
    //        FirstName = firtsName;
    //        LastName = lastName;
    //        Id = id;

    //    }
    //    public void printPerson()
    //    {
    //        Console.WriteLine("Name: " + LastName + ", " + FirstName + "\nID: " + Id);
    //    }
    //}
    //public class Student : Person
    //{
    //    private int[] TestScores;

    //    public Student(string firtsName, string lastName, int id, int[] scores) : base(firtsName, lastName, id)
    //    {
    //        TestScores = scores;
    //    }
    //    public char Calculate()
    //    {
    //        int totalScore = 0;
    //        foreach (int score in TestScores)
    //        {
    //            totalScore += score;
    //        }
    //        int avarageScore = totalScore / TestScores.Length;
    //        if (avarageScore >= 90 && avarageScore <= 100)
    //            return 'O';
    //        else if (avarageScore >= 80 && avarageScore < 90)
    //            return 'E';
    //        else if (avarageScore >= 70 && avarageScore < 80)
    //            return 'A';
    //        else if (avarageScore >= 55 && avarageScore < 70)
    //            return 'P';
    //        else if (avarageScore >= 40 && avarageScore < 55)
    //            return 'D';
    //        else
    //            return 'T';
    //    }
    //}
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int CalculatePerimeter()
        {
            int perimeter = 2 * (Width + Height);
            return perimeter;
        }
        public int CalculateArea()
        {
            int area = Width * Height;
            return area;
        }
    }
    public class Circle
    {
        public int Radius { get; set; }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;

        }
        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = 0;//start speed 
        }
        public void Accelerate(int accelerationAmount)
        {
            Speed += accelerationAmount;
        }
        public void Decelerate(int decelerationAmount)
        {
            Speed -= decelerationAmount;
            if (Speed < 0)
            {
                Speed = 0;
            }

        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double CurrentSalary { get; set; }
        public int PerformanceRating { get; set; }
        public Employee(string firstName, string lastName, string department, string position, int currentSalary, int rating)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Position = position;
            CurrentSalary = currentSalary;
            PerformanceRating = rating;
        }
        public void IncreaseSalary()
        {
            double baseIncrease = 0.05;
            double positionFactor = GetPositionFactor();
            double ratingFactor = GetRatingFactor(PerformanceRating);
            double totalIncrease = baseIncrease + ratingFactor + positionFactor;
            double newSalary = CurrentSalary * (1 + totalIncrease);
            CurrentSalary = newSalary;
            Console.WriteLine(newSalary);
        }
        public double GetPositionFactor()
        {
            double positionFactor = 0;
            if (Position == "Engineer")
            {
                positionFactor = 0.01;
            }
            else if (Position == "Manager")
            {
                positionFactor = 0.15;
            }
            return positionFactor;

        }
        public double GetRatingFactor(int rating)
        {
            double ratingFactor = 0;
            if (rating >= 8)
            {
                ratingFactor = 0.01;
            }
            else if (rating >= 5 && rating < 8)
            {
                ratingFactor = 0.05;
            }
            else
            {
                Console.WriteLine("There is no salary increase.");
            }
            return ratingFactor;
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, string publisher, string isbn)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ISBN = isbn;
        }

    }
    public class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(string isbn)
        {
            Book bookToRemove = Books.Find(m => m.ISBN == isbn);
            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);

            }
            else
            {
                Console.WriteLine("This book is not found:");
            }
        }
        public Book SearchBook(string isbn)
        {
            return Books.Find(book => book.ISBN == isbn);
        }
        public void GetAllBooks()
        {
            Console.WriteLine("The list of all books: ");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title}| Author is {book.Author}|The Publisher is {book.Publisher}|ISBN is {book.ISBN} ");
            }
        }

        
    }
    public class Bank
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Bank(string name, string accounNumber, double balance)
        {
            Name = name;
            AccountNumber = accounNumber;
            Balance = balance;
        }
        public void Deposit(double addedMoney)
        {
            if (addedMoney <= 0)
            {
                Balance = 0;
                Console.WriteLine("Can not add 0 or negative");
            }
            else
            {
                Balance += addedMoney;
                Console.WriteLine($"{addedMoney} added. New balance: {Balance}");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("The balance in the account is not sufficient");
            }
           else if (amount <= 0)
            {
                Console.WriteLine( "Cannot withdraw 0 or negative amount.");
            }
            else
            {
                Balance-=amount;
                Console.WriteLine($"{amount} withdrawn. Your balace is: {Balance}");
       
            }

        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }

    //public class Personn
    //{
    //    public string Name { get; set; }
    //    public Personn(string name)
    //    {
    //        Name = name;
    //    }
    //    public override string ToString()
    //    {
    //        return "Hello! My name is " + Name;
    //    }
    //}
 

}