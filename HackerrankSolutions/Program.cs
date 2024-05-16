namespace HackerrankSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] { { 1, 2, 4 }, { 5, 6, 7 } };
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}