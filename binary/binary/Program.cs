using System;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 33));
        }

        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        public static int BinarySearch(int [] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int middle = (left + right) / 2;
            int potentialMatch = array[middle];
            if(target== potentialMatch)
            {
                return middle;
            }else if (target < potentialMatch)
            {
                return BinarySearch(array, target, left, middle - 1);
            }
            else
            {
                return BinarySearch(array, target, middle + 1, right);
            }
        }
    }
}
