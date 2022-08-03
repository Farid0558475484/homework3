using System;

namespace Array.verilir.arrayin.ən.kicik.elementini.tapan.algoritm.yazmag
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 144, 23525, 456, 242, 5576, 2424, 75, 635, 4325, 735 };
            int min = arr[0];



            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i]<min)

                {
                    min = arr[i];
                }

            }
            Console.WriteLine(min);
        }


    }
}





