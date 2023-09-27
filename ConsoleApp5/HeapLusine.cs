using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5
{
    public class HeapLusine
    {
        public void SortHeap()
        {
            var notSorted = new List<int>() { 25, 8, 6, 2, 15 };

            for (int i = notSorted.Count / 2; i >= 0 ; i--)
            {
                MaxHeap(notSorted, notSorted.Count, i);
            }

            var root = 0;

            for (int i = notSorted.Count - 1 ; i >= 0; i--)
            {
                var val = notSorted[i];

                notSorted[i] = notSorted[root];

                notSorted[root] = val;

                MaxHeap(notSorted, i, root);
            }

            Console.WriteLine();

            foreach (var item in notSorted)
            {
                Console.Write(item + " ");
            }
        }

        public void MaxHeap(List<int> array, int arrayLength, int parentindex)
        {
            var lchIndex = parentindex * 2 + 1;

            var rchIndex = parentindex * 2 + 2;

            var largeIndex = parentindex;

            if(lchIndex < arrayLength && array[lchIndex] > array[largeIndex])
            {
                largeIndex = lchIndex;
            }
            else if(rchIndex < arrayLength && array[rchIndex] > array[largeIndex])
            {
                largeIndex = rchIndex;
            }

            if(largeIndex != parentindex)
            {
                var val = array[parentindex];

                array[parentindex] = array[largeIndex];

                array[largeIndex] = val;

                Console.WriteLine();

                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }

                MaxHeap(array, arrayLength, largeIndex);
            }
        }

    }
}
