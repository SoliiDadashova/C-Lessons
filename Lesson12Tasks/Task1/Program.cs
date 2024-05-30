
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\compo\Desktop\";
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter the number: ");
                int input = int.Parse(Console.ReadLine());
                string newFolderPath = Path.Combine(path, "Test");
                if (!Directory.Exists(newFolderPath))
                {
                    Directory.CreateDirectory(newFolderPath);
                }
                string fileName = "tests.txt";
                string filePath = Path.Combine(newFolderPath, fileName);
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    for (int i = 0; i < input; i++)
                    {
                        sw.WriteLine($"Input Line {i + 1}: Line{i + 1}\r\n");
                    }
                    for (int i = input; i > 0; i--)
                    {
                        Console.WriteLine($"Input Line {i}: Line{i}\r\n");
                        break;
                    }
                }
            }
        }
    }
}