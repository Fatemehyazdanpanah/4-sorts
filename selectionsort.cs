
namespace ConsoleApp30
{
    public class SelectionSort : ISortable
    {
        public int[] SortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public int[] SortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = numbers[maxIndex];
                numbers[maxIndex] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }
    }

}
