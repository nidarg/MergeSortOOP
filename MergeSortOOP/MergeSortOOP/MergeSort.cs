using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortOOP
{
    public class MergeSort
    {
        public int[] Sort(int[] arrToSort)
        {
            if (arrToSort.Length == 1)
                return arrToSort;

            var splitter = new Splitter(arrToSort);
            int[] firstSplittedArray = splitter.GetFirstPart();
            int[] secondSplittedArray = splitter.GetSecondPart();

            int[] firstSortedArray = Sort(firstSplittedArray);
            int[] secondSortedArray = Sort(secondSplittedArray);
            var merger = new Merger();
            return merger.Merge(firstSortedArray, secondSortedArray);

            
        }
    }
}
