using Newtonsoft.Json;

namespace Lesson11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 12;
            int b = a;
            Console.WriteLine(a); //12
            Console.WriteLine(b); //12
            ChangeNumber( ref a);
            Console.WriteLine(a); //12
            Console.WriteLine(b); //12
            /*Person person1 = new Person();
            person1.Name = "Alice";
            Person person2 = person1;
            person2.Name = "Bob";
            Console.WriteLine($"person1.Name: {person1.Name}");
            Console.WriteLine($"person2.Name: {person2.Name}");*/

        }
        static void ChangeNumber( ref int number)
        {
            //int number = 12;
            number = 100;
        }


        /*static async Task Main(string[] args)
        {
            const string myURl = "https://catfact.ninja/fact";
            bool IsContinue = false;
            HttpClient client = new HttpClient();
            Console.WriteLine("Showing Cat Facts: \r\n");
            do
            {
                var result = await client.GetStringAsync(myURl);
                var catfact = JsonConvert.DeserializeObject<CatFact>(result);

                Console.WriteLine(catfact.Fact);
                Console.WriteLine();
                Console.WriteLine("Do you want to see another fact? (yes/no): ");

                string userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "yes")
                {
                    IsContinue = true;
                }
                else
                {
                    IsContinue = false;
                }
            }
            while (IsContinue);*/

        /* User user = new User()
            {
                Name = "Solmaz",
                isStudent = true,
                Parent = new Person()
                {
                    Name = "Yegane",
                    DateOfBirth = new DateTime(1975, 09, 30)
                },
                Children = new Person[]
                {
                    new Person()
                    {
                        Name="MAmed",
                        DateOfBirth = new DateTime(2006,11,23)
                    }
                }               
            };
            var jsonString= JsonConvert.SerializeObject(user,Formatting.Indented);
            Console.WriteLine(jsonString);*/
    }
}
    public class User
    {
        public string Name { get; set; }
        public bool isStudent { get; set; }
        public int Age { get; set; }
        public Person Parent { get; set; }
        public Person[] Children { get; set; }

    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class CatFact
    {
        public int Lenght { get; set; }
        public string Fact { get; set; }

    }
