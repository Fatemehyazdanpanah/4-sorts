
namespace ConsoleApp30
{
    public class MergeSort : ISortable
    {
        public int[] SortAscending(int[] numbers)
        {
            MergeSortAlgorithm(numbers, 0, numbers.Length - 1, true);
            return numbers;
        }

        public int[] SortDescending(int[] numbers)
        {
            MergeSortAlgorithm(numbers, 0, numbers.Length - 1, false);
            return numbers;
        }

        private void MergeSortAlgorithm(int[] numbers, int left, int right, bool ascending)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortAlgorithm(numbers, left, mid, ascending);
                MergeSortAlgorithm(numbers, mid + 1, right, ascending);
                Merge(numbers, left, mid, right, ascending);
            }
        }

        private void Merge(int[] numbers, int left, int mid, int right, bool ascending)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            Array.Copy(numbers, left, leftArr, 0, n1);
            Array.Copy(numbers, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (ascending ? leftArr[i] <= rightArr[j] : leftArr[i] >= rightArr[j])
                {
                    numbers[k++] = leftArr[i++];
                }
                else
                {
                    numbers[k++] = rightArr[j++];
                }
            }

            while (i < n1) numbers[k++] = leftArr[i++];
            while (j < n2) numbers[k++] = rightArr[j++];
        }
    }

}
