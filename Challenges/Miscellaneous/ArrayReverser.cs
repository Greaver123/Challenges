using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Miscellaneous
{
    public class ArrayReverser
    {

        public int[] Reverse(int[] array)
        {
            if (array.Count()==0)
            {
                throw new ArgumentException();
            }
            for (int i = 0, j = array.Count()-1; i != j; i++)
            {
                int temp = array[i];
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
    }
}
