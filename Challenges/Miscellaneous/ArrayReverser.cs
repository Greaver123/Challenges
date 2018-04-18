﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Miscellaneous
{
    public class ArrayReverser<T>
    {

        public T[] Reverse(T[] array)
        {
            if (array.Count()==0)
            {
                throw new ArgumentException();
            }
            for (int i = 0, j = array.Count()-1; i != j; i++)
            {
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j--;
                if (i==j)
                {
                    return array;
                }

            }
            return array;

        }

        public T[] ReverseBuiltIn(T[] array)
        {
            Array.Reverse(array);
            return array;
        }
    }
}
