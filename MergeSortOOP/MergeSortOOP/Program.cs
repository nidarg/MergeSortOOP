using System;

namespace MergeSortOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToSort = new[] {5,3,1,6,4 };
            var mergeSorter = new MergeSort();
            var sortedArrray = mergeSorter.Sort(arrayToSort);
            foreach (var i in sortedArrray)
                Console.WriteLine(i);
            Console.Read();
        }
    }
}
