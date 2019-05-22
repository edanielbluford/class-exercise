using System;
using System.Collections.Generic;

namespace class_exercise
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arrayOne = new int[5];



            int[] arrayTwo = { 1, 2, 3, 4 };

            //arrayOne[3] = 44;


            for (int iterator = 0; iterator < arrayOne.Length; iterator++)
            {
                Console.WriteLine("Please Enter a Number");
                arrayOne[iterator] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arrayOne[iterator]);
            }



            //printing numbers in array


            foreach (int item in arrayOne)
            {
                Console.WriteLine(item);
            }

            // sum arrray One

            int sum = 0;



            foreach (int number in arrayOne)
            {
                
                sum = sum + number;

            }

            Console.WriteLine(sum);



            //putting numbers in a new array
            int[] arrayThree = new int[7];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayThree[i] = arrayOne[i];
            }




            List<int> numberList = new List<int>();


            foreach (int number in arrayOne)
            {
                numberList.Add(number);
            }


;
        }
    }
}
