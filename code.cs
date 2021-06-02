using System;

namespace array
{
    class program
    {
        static void main(string[] args)
        {
            int num, i, j = 0, larg, larg2nd;
            int[] arr1 = new int[50];
            Console.WriteLine("input the size of array:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("input  {0} elements in the array : \n", num);
            for (i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            larg = 0;
            for (i = 0; i < num; i++)
            {
                if (larg < arr1[i])
                 {
                    larg = arr1[i];
                    j = i;
                }
            }
            larg2nd = 0;
            for (i = 0; i < num; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                     }
                else
                {
                    if (larg2nd < arr1[i])
                    {
                        larg2nd = arr1[i];
                    }
                }
            }

            Console.WriteLine("the second largest element in the array is : {0} \n\n", larg2nd);
            Console.ReadLine();
        }
    }
}
