namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BubbleSort
            //Time Complexity: O(N^2)


            /*int[] array = { 12, 3, 5, 1 };
             BubbleSort(array);
             Console.WriteLine(string.Join(",", array));*/

            #endregion
            #region InsertionSort
            /*int[] array = { 16, 11, 7, 8, 20 };
            InsertionSort(array);
            Console.WriteLine(string.Join(",", array));*/
            #endregion
            #region SelectionSort
            /*int[] array = { 16, 11, 7, 8, 20 };
           SelectionSort(array);
           Console.WriteLine(string.Join(",", array));*/
            #endregion

        }
        static void BubbleSort(int[]arry)
        {
            for(int i = 0; i < arry.Length; i++)
            {
                for (int j = 0; j < arry.Length - i - 1; j++)
                {
                    if (arry[j] > arry[j + 1])
                    {
                        var temp = arry[j];
                        arry[j] = arry[j + 1];
                        arry[j + 1] = temp;
                    }
                }
            }
          
           
        }
        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                int minValuIndex = i;
                for(int j=i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minValuIndex])
                    {
                        minValuIndex = j;
                    }
                }
                var temp = array[i];
                array[minValuIndex] = array[i];
                array[i] = temp;
            }
        }
        static void InsertionSort(int[]array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j= i - 1;
                while(j>=0&& array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            
        }
    }
}