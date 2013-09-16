using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoExercices
{
    public class Mirror
    {
        public int MirrorLength(int[] vector)
        {
            int max = 0;
            int count =0;
            bool isMirror=false;
            if(vector.Length>=2)
            {
                int halfLength = vector.Length / 2;
                int[] secondHalf; 
                secondHalf = new int[halfLength];
                for (int i = 0; i < halfLength; i++)
                {
                    if(vector.Length%2==0)
                        secondHalf[i] = vector[(halfLength)+i];
                    else
                        secondHalf[i] = vector[(halfLength+1) + i];
                }
                for (int i = 0; i < halfLength; i++)
                {

                    if (vector[i] == secondHalf[(halfLength - 1) - i])
                    {
                        isMirror = true;
                        count++;
                        if (count >= max)
                            max = count;
                    }
                    else
                        count = 0;
                            
                }
            }
            return max;
        }
    }
}
