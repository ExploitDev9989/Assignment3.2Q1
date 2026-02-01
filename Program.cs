namespace arraywithoutAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the amount of rows : ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the amount of colums : ");
            int col = int.Parse(Console.ReadLine());

            int[,] numbers = new int[rows, col];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter the numbers in the array");
                    numbers[i, j] = int.Parse(Console.ReadLine());

                }


            }
            Console.WriteLine("Matrix output: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("| " + numbers[i, j] + " ");
                    

                }
                Console.WriteLine("|");
            }


        }

    }
}

