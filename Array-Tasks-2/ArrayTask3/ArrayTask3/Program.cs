using System;

namespace ArrayTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
            int[] arrT_3 = CombinationArray(ref arrT_1, arrT_2);
            

            PrintData(arrT_1, "arrT_1:");
            PrintData(arrT_2, "arrT_2:");
            PrintData(arrT_3, "arrT_3:");
        }

        static int[] RndArray(int length)  
        {
            Random rnd = new Random();
            int[] arrT = new int[length];

            for (int i = 0; i < length; i++)
            {
                arrT[i] = rnd.Next(20);
            }
            return arrT;            
        }

        static void PrintData(int[] arrX, string label)
        {
            Console.Write($"{label}");

            for (int i = 0; i < arrX.Length; i++)
            {
                Console.Write($"{arrX[i]:d2} ");
            }
            Console.WriteLine();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrT_1"></param>
        /// <param name="arrT_2"></param>
        /// <returns></returns>
        
        static int[] CombinationArray(ref int[] arrT_1, int[] arrT_2)
        {
            int[] arrCa = new int[arrT_1.Length];
            for (int i = 0; i < arrT_1.Length; i++)
            {
                if (arrT_1[i] > arrT_2[i])
                    arrCa[i] = arrT_1[i];

                else
                    arrCa[i] = arrT_2[i];

            }
            return arrCa;
        }





    }
}

