using System;

namespace Manipulating_ArraysWhiteboard
{
    class Program
    {
        static void PrintArray(int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
        static int ArraySum(int[] numbers)
        {
            int sum = 0;

            foreach (var x in numbers)
            {
                sum = +x;
            }
            


            return sum;
        }
        static double ArrayAverage(int[] numbers) => (double) ArraySum(numbers) / (double) numbers.Length;
        
        static void PrintReverseArray(int[] numbers)
        {
            for (int i = numbers.Length-1; i > 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }
                                           
            static int [] ReverseArray(int[] numbers)
            {

            int[] backward = new int[numbers.Length];

                 for(int i = 0; i < numbers.Length; i++)
                 {
                      backward[i] = numbers[numbers.Length - 1 - i];
                 }

            return backward;

            }
        static int[] Rotate(int NumSteps, int[] numbers)
        {
            int[] rotated = new int[numbers.Length];

            

            

            return rotated;

        }

        static int[] Rotate(string direction, int NumSteps, int[] numbers )
        {
            int[] rotated = new int[numbers.Length];

            if (direction.ToLower() == "left")
            {
                NumSteps = -NumSteps;
            }

            return Rotate(NumSteps, numbers);
        }

        static void TestMethodForExercises()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //0
            Console.Write($"Print Array A: ");
            PrintArray(ArrayA);
            Console.Write($"Print Array B: ");
            PrintArray(ArrayB);
            Console.Write($"Print Array C: ");
            PrintArray(ArrayC);

            //1
            Console.WriteLine($"Get Average A. {ArrayAverage(ArrayA)} ");
            Console.WriteLine($"Get Average B. {ArrayAverage(ArrayB)} ");
            Console.WriteLine($"Get Average C. {ArrayAverage(ArrayC)} ");

            //2
            Console.Write("Reversed Array A: ");
            PrintReverseArray(ArrayA);

            Console.Write("Reversed Array B: ");
            PrintReverseArray(ArrayB);

            Console.Write("Reversed Array C: ");
            PrintReverseArray(ArrayC);


            //3

        }
        static void Main(string[] args)
        {
            TestMethodForExercises();
        }

       
    }
}
