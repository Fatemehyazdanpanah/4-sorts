

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++) numbers[i] = rand.Next(1, 101);

            ISortable bubbleSort = new BubbleSort();
            ISortable selectionSort = new SelectionSort();
            ISortable insertionSort = new InsertionSort();
            ISortable mergeSort = new MergeSort();

            Console.WriteLine("Bubble Sort Ascending:");
            PrintArray(bubbleSort.SortAscending((int[])numbers.Clone()));

            Console.WriteLine("Bubble Sort Descending:");
            PrintArray(bubbleSort.SortDescending((int[])numbers.Clone()));

            Console.WriteLine("Selection Sort Ascending:");
            PrintArray(selectionSort.SortAscending((int[])numbers.Clone()));

            Console.WriteLine("Selection Sort Descending:");
            PrintArray(selectionSort.SortDescending((int[])numbers.Clone()));

            Console.WriteLine("Insertion Sort Ascending:");
            PrintArray(insertionSort.SortAscending((int[])numbers.Clone()));

            Console.WriteLine("Insertion Sort Descending:");
            PrintArray(insertionSort.SortDescending((int[])numbers.Clone()));

            Console.WriteLine("Merge Sort Ascending:");
            PrintArray(mergeSort.SortAscending((int[])numbers.Clone()));

            Console.WriteLine("Merge Sort Descending:");
            PrintArray(mergeSort.SortDescending((int[])numbers.Clone()));
        }

        static void PrintArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}
