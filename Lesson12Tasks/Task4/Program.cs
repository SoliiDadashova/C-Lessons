namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter the amount of gasoline: ");
            int gasolineAmount=int.Parse(Console.ReadLine());   
            var car = new Car(0);
           if (car.Refuel(gasolineAmount))
            {
                car.Drive();
            }*/

            Console.WriteLine("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());
            var calculator = new Calculator();
            Console.WriteLine($"{x}+{y}={calculator.Add(x,y)}");
            Console.WriteLine($"{x}-{y}={calculator.Subtract(x, y)}");
            Console.WriteLine($"{x}/{y}={calculator.Divide(x, y)}");
            Console.WriteLine($"{x}*{y}={calculator.Multiply(x, y)}");
        }
  
    }
    public class Car : IVehicle
    {
        public int Gasoline { get; set; }
        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }
        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Can not driving");
            }
        }

        public bool Refuel(int gasolineAmount)
        {
            if(gasolineAmount > 0)
            {
                Gasoline += gasolineAmount;
                return true;
            }
            return false;
        }
    }
    public class Calculator : ICalculate
    {
        public int x { get; set; }
        public int y { get; set; }
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x- y;
        }
       
    }
}