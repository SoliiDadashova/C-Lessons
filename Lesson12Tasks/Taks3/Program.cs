namespace Taks3
{
    internal class Program
    {
        const string myPath = @"C:\Users\compo\Downloads";
        static void Main(string[] args)
        {
            string[] directories = Directory.GetDirectories(myPath,"*",SearchOption.AllDirectories);//ulduz butun hamisini goturur
            string[] files = Directory.GetFiles(myPath, "*", SearchOption.AllDirectories);
            var  directoryCount = directories.Length;
            var filesCount = files.Length;
            var allCount= directoryCount+filesCount;
            Console.WriteLine(allCount);

        }
    }
}