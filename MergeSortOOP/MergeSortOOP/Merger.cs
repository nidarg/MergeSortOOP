using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortOOP
{
    public class Merger
    {


        public int[] Merge(int[] firstSortedArray,int[] secondSortedarray)
        {
            int[] mergedArray = new int[firstSortedArray.Length + secondSortedarray.Length];

           
            //
            int indexFirst = 0, indexSecond = 0, indexMerged = 0;
            //while either array still has an element
            while (indexFirst < firstSortedArray.Length || indexSecond < secondSortedarray.Length)
            {
                //if both arrays have elements  
                if (indexFirst < firstSortedArray.Length && indexSecond < secondSortedarray.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (firstSortedArray[indexFirst] <= secondSortedarray[indexSecond])
                    {
                        mergedArray[indexMerged] = firstSortedArray[indexFirst];
                        indexFirst++;
                        indexMerged++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        mergedArray[indexMerged] = secondSortedarray[indexSecond];
                        indexSecond++;
                        indexMerged++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexFirst < firstSortedArray.Length)
                {
                    mergedArray[indexMerged] = firstSortedArray[indexFirst];
                    indexFirst++;
                    indexMerged++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexSecond < secondSortedarray.Length)
                {
                    mergedArray[indexMerged] = secondSortedarray[indexSecond];
                    indexSecond++;
                    indexMerged++;
                }
            }
            return mergedArray;
        }
    }
}
