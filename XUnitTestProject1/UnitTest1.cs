using System;
using Xunit;

using MergeSortOOP;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[]{3, 2, 1, 4 }, new[] { 1,2,3,4})]
        public void TestSortingMethod(int[] arrToSort, int[] expected)
        {
            int[] actual = new  MergeSort().Sort(arrToSort);
            for(int i = 0; i < arrToSort.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }


        [Theory]
        [InlineData(new[] { 3, 2, 1, 4,5 }, new[] { 3,2})]
        public void TestSplittArrayFirstPart(int[] arrToSort, int[] expected)
        {
            int[] actual = new Splitter(arrToSort).GetFirstPart();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 3, 2, 1, 4, 5 }, new[] { 1,4,5})]
        public void TestSplittArraySecondPart(int[] arrToSort, int[] expected)
        {
            int[] actual = new Splitter(arrToSort).GetSecondPart();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Theory]
        [InlineData(new[] { 1,2,3 }, new[] { 4, 5 },new[] { 1, 2, 3, 4, 5 } )]
        public void TestMergeSortedArrays(int[] firstSortedArray,int[]secondSortedArray int[] expected)
        {
            int[] actual = new Merger().Merge(firstSortedArray,secondSortedArray);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
