namespace Git
{
    internal class Lesson3
    {
        /// <summary>
        /// Determine the number of three-digit natural numbers whose sum of digits is equal to n
        /// </summary>
        public static void Task1()
        {
            // 100 - 999;
            //Array [100 - 999];

            // 123 -> 3
            // int x = number % 10;
            // 123 -> 12.3 -> 12 -> 3
            // 123 -> 1.23 -> 1

            int expectedSumm = 10;
            int countOfnumber = 0;

            for (int i = 100; i < 1000; i++)
            {
                int result = 0;
                int currentNumber = i;

                Console.Write(currentNumber);

                while (currentNumber > 0)
                {
                    result += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                if (result == expectedSumm)
                {
                    countOfnumber++;
                    Console.Write(" -  true\n");
                }
                Console.WriteLine();
            }
        }

        // Task2
        // create new array
        public static void Arrays()
        {
            Random random = new Random();
            int[] numbers = { 1, 2, 4, 5, 76, 67, 4, 54, 53, };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)random.NextInt64(0, 5);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            foreach (int number in numbers)
            {
                Console.Write(number);
            }

            int j = 0;
            do
            {
                Console.Write(numbers[j] + " ");
                j++;
            }
            while (j < numbers.Length);

            j = -1;
            do
            {
                Console.WriteLine("I am DO-WHILE cycle");
            }
            while (j > 0);

            for (int i = -1; i > 0; i++)
            {
                Console.WriteLine("I am FOR cycle");
            }

            //calculate amount of number 4
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 4)
                {
                    result++;
                }
            }

            foreach (int number in numbers)
            {
                if (number == 4)
                {
                    result++;
                }
            }

            Console.WriteLine("\n " + result);
        }

        public static void TwoDimensionalArray()
        {
            Random random = new Random();
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (int)random.NextInt64(20, 99); ;
                }
            }

            int maxNumberMultiDimension = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxNumberMultiDimension)
                    {
                        maxNumberMultiDimension = matrix[i, j];
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Main: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i] + " ");
            }

            Console.Write("Additional: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, matrix.GetLength(0) - i - 1] + " ");
            }

            Console.WriteLine("Array max number :" + maxNumberMultiDimension);
            /*
             * 00 01 02 03
             * 10 11 12 23
             * 20 21 22 23
             * 30 31 32 33
             * 
             * ij
             * 0x = matrix.GetLength(0)
             * 1x = 3
             * 2x = 3
             * 3x = 3
             * 
             */
        }
    }
}
