using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortOOP
{
    public class Splitter
    {
        private readonly int[] arrToSort;
        private readonly int[] firstPart;
        private readonly int[] secondPart;


        public Splitter(int[] arrToSort)
        {
            this.arrToSort = arrToSort;
            firstPart = new int[arrToSort.Length / 2];
            secondPart = new int[arrToSort.Length - firstPart.Length];
        }

        public int[] GetFirstPart()
        {
            for (int i = 0; i < (arrToSort.Length / 2); i++)
                firstPart[i] = arrToSort[i];

            return firstPart;
        }
        public int[] GetSecondPart()
        {
            for (int i = 0; i < (arrToSort.Length - (arrToSort.Length / 2)); i++)
                secondPart[i] = arrToSort[firstPart.Length+i];

            return secondPart;
        }
    }
}
