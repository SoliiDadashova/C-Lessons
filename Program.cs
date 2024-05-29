using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Diagnostics;
using System.Management;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Please enter your name: ");
            string inputName=Console.ReadLine();
            string myUrl = $"https://api.genderize.io?name={inputName}";
            HttpClient client = new HttpClient();
            var result=client.GetStringAsync(myUrl).Result;
            var jsonResult = JsonConvert.DeserializeObject<Application>(result);
            Console.WriteLine($"Name: {jsonResult.name}");
            Console.WriteLine($"Gender: {jsonResult.gender}");
            Console.WriteLine($"Probability: {jsonResult.probability}");*/

            /*IUserRepository userRepository = new UserRepository();
            userRepository.Add(new User { ID = 1, Name = "Solmaz", Email = "solmzd334@gmail.com" });
            userRepository.Add(new User { ID = 2, Name = "Ali", Email = "aliyev22@gmail.com" });
            var users= userRepository.GetAll();
            foreach(var user in users)
            {
                Console.WriteLine($"Name: {user.Name}\r\n" +
                    $"Email: {user.Email}\r\n");
            }
            userRepository.Update(new User { ID = 1, Name = "Soli", Email = "solmzd334@gmail.com" });
            var userById=userRepository.Get(2);
            Console.WriteLine($"Id: {userById.ID}, Name: {userById.Name}, Email: {userById.Email}");
            userRepository.Delete(2);
            var users1 = userRepository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}\r\n" +
                    $"Email: {user.Email}\r\n");
            }*/

            /*Employee employee = new FullTimeEmployee("Solmaz",1,1000);
            Employee employee1 = new PartTimeEmployee("Joe", 2, 100, 27);
            Employee employee2 = new Intern("Ali", 3, 1000);
            Console.WriteLine($"{employee.Name} (Full-Time) Salary: {employee.CalculateSalary()}");
            Console.WriteLine($"{employee1.Name} (Part-Time) Salary: {employee1.CalculateSalary()}");
            Console.WriteLine($"{employee2.Name} (Intern) Salary: {employee2.CalculateSalary()}");*/

            /* Console.WriteLine("Please enter the name: ");
           string inputName = Console.ReadLine();
           string path = $"https://api.genderize.io?name={inputName}";
           using (HttpClient client=new HttpClient())
           {
               HttpResponseMessage response = await client.GetAsync(path);
               if(response.IsSuccessStatusCode)
               {
                   var result= await response.Content.ReadAsStringAsync();
                   var jsonResult = JsonConvert.DeserializeObject<Application>(result);
                   Console.WriteLine($"Name: {jsonResult.name}");
                   Console.WriteLine($"Gender: {jsonResult.gender}");
                   Console.WriteLine($"Probability: {jsonResult.probability}");
               }
           }*/

            /*Console.WriteLine("Please enter your name: ");
            string inputName=Console.ReadLine();
            string url = $"https://api.nationalize.io?name={inputName}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response=await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<Application2>(result);
                    Console.WriteLine($"Name is: {jsonResult.Name}");
                    foreach(var item in jsonResult.country )
                    {
                        Console.WriteLine($"Country is: {item.country_id},probability is: {item.probability} ");
                    }
                }
            }*/

            /*string url = "https://dog.ceo/api/breeds/image/random";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "DogImages");
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using(HttpClient client = new HttpClient())
            {
                
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var JSONresult = JsonConvert.DeserializeObject<DogImageResponse>(result);
                    string imageURL = JSONresult.message;
                    string fileName = Path.GetFileName(new Uri(imageURL).LocalPath);
                    var filePath = Path.Combine(folderPath, fileName);
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(imageURL, filePath);
                    }
                    Console.WriteLine($"Image downloaded and saved to: {filePath}");

                }
                else
                {
                    Console.WriteLine("Failed to retrieve the image URL.");
                }


            }*/

            /*Console.WriteLine("Enter your name: ");
            string input=Console.ReadLine();
            string url = $"https://api.agify.io?name={input}";
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string result=await responseMessage.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<Agify>(result);
                    Console.WriteLine($"Name is: {jsonResult.name}\r\n" +
                        $"Age is: {jsonResult.age}");
                    
                }
            }*/

            /* string apiUrl = "https://datausa.io/api/data?drilldowns=Nation&measures=Population";

            using(var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                PopulationData populationData = JsonConvert.DeserializeObject<PopulationData>(responseBody);

                foreach (var result in populationData.Data)
                {
                    Console.WriteLine($"Year: {result.Year}, Population: {result.Population},Nation: {result.Nation}");
                }
            }*/

            //Task1(We need to show how many drives we have currently (C, D and etc), also for each one show total size, available size and used size (in MB))
            /*Console.WriteLine("Drive Information");
            foreach(DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if(driveInfo.IsReady)
                {
                    long totalSize = driveInfo.TotalSize / (1024 * 1024);
                    long aviableSize=driveInfo.AvailableFreeSpace / (1024 * 1024);
                    long usedSize = totalSize - aviableSize;
                    Console.WriteLine($"Drive {driveInfo.Name}");
                    Console.WriteLine($"  Total Size: {totalSize} MB");
                    Console.WriteLine($"  Available Size: {aviableSize} MB");
                    Console.WriteLine($"  Used Size: {usedSize} MB");
                }
            }*/

            //Task2(Show size of RAM and current usage (how many MB is in use now))
            /*ObjectQuery winQuery= new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher= new ManagementObjectSearcher(winQuery);
            foreach (ManagementObject item in searcher.Get())
            {
                long totalRam = long.Parse(item["TotalVisibleMemorySize"].ToString()) / 1024; //Toplam RAM kilobayt qaytarir deye 1024 boluruk
                long availableRam = long.Parse(item["FreePhysicalMemory"].ToString()) / 1024; 
                long usedRam = totalRam - availableRam; 

                Console.WriteLine("\nMemory Information:");
                Console.WriteLine($"  Total RAM: {totalRam} MB");
                Console.WriteLine($"  Available RAM: {availableRam} MB");
                Console.WriteLine($"  Used RAM: {usedRam} MB");
            }*/

            //Task3(Show current CPU usage in percentage)
            /*PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            System.Threading.Thread.Sleep(1000);

            float cpuUsage = cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            cpuUsage = cpuCounter.NextValue();
            Console.WriteLine($"Current CPU Usage: {cpuUsage}%");*/

            //Task4(Shut Down pc)
           /* Console.WriteLine("Enter the minute: ");
            int minute=int.Parse(Console.ReadLine());
            int seconds = minute * 60;
            ProcessStartInfo startInfo = new ProcessStartInfo("shutdown", $"/s /t {seconds}");
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
            Console.WriteLine($"The computer will shut down in {minute} minute(s).");*/

        }
    }
    public class PopulationDataResult
    {
        public string ID { get; set; }
        public string Year { get; set; }
        public string Nation { get; set; }
        public string Population { get; set; }
    }

    public class PopulationData
    {
        public PopulationDataResult[] Data { get; set; }
    }
    public class Agify
    {
        public int count { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
    public class DogImageResponse
    {
        public string message { get; set; }
        public string status { get; set; }
    }

    public class Country
    {
        public string country_id { get; set; }
        public double probability { get; set; }
    }
    public class Application2
    {
        public string Name { get; set; }
        public List<Country> country { get; set; }
    }
    public class Application
    {
        public int count { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double probability { get; set; }

    }
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public abstract double CalculateSalary();
    }
    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public FullTimeEmployee(string name, int id, double monthlySalary) : base(name, id)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public PartTimeEmployee(string name, int id, double hourlyRate, int hoursWorked) : base(name, id)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    public class Intern : Employee
    {
        public double MonthlyStipend { get; set; }
        public double MaxStipend { get; set; } = 1000;
        public Intern(string name, int id, double monthlyStipend) : base(name, id)
        {
            MonthlyStipend = monthlyStipend;
        }

        public override double CalculateSalary()
        {
            //return MonthlyStipend > MaxStipend ? MaxStipend : MonthlyStipend; /ternory operotr
            if (MonthlyStipend > MaxStipend)
            {
                return MaxStipend;
            }
            else { return MonthlyStipend; }
        }
    }
}