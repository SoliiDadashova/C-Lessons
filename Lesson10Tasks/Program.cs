namespace Lesson10Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle(12, 8);
            shapes[1] = new Circle(5);
            foreach (Shape shape in shapes)
            {
                double area = shape.Area();
                double perimeter=shape.PeriMeter();
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine("--------------------------------");;
            }*/
            
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Name = "Solmaz";
            schoolPerson.Surname = "Dadashova";
            schoolPerson.Greet();
            Student schoolPerson1 = new Student();
            schoolPerson1.Age = 21;
            schoolPerson1.Name = "Joe";
            schoolPerson1.Surname = "Thomas";
            schoolPerson1.Greet();
            schoolPerson1.GoToClasses();

        }
    }


    public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 6 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 6 and 50.");
                }
                else
                {
                    _age = value;
                }

            }
        }
    
        public DateTime DateOfBirth { get; set; }
        public string CurrentClass { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello {Name} {Surname}");
        }
        public virtual void GoToClasses()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }
    }

    public class Student:SchoolPerson
    {
        public override void GoToClasses()
        {
            Console.WriteLine($"I'm {Name} {Surname}, I'm a student and  I'm going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age}");
        }
    }

    public class Teacher:SchoolPerson
    {
        private string _subject;
        public override void GoToClasses()
        {
            Console.WriteLine($"I'm {Name} {Surname}, I am a teacher");
        }
        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {_subject}");
        }
    }
    public class Shape
    {
        Location location;
        public override string ToString()
        {
            return " ";
        }
        public virtual double Area()
        {
            return 0;
        }
        public  virtual double PeriMeter()
        {
            return 0;
        }

    }
    public class Circle:Shape
    {
       protected double Radius;
        public Circle(double radius)
        {
            Radius= radius;
        }
        public override double Area()
        {
            return Math.PI * Radius;
        }
        public override double PeriMeter()
        {
            return 2*Math.PI* Radius;   
        }
    }
    public class Rectangle:Shape
    {
       protected double Side1;
       protected  double Side2;
        public Rectangle(double side1,double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public override double Area()
        {
            return Side1*Side2;
        }
        public override double PeriMeter()
        {
            return 2*(Side1+Side2);
        }

    }
    public class Location
    {
        private double x;
        private double y;
    }
}