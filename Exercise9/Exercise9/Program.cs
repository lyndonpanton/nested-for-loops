namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following part of this program will printed a box of asterisks with a given width and height");
            Console.WriteLine();

            int numberOfRows = 0;

            while (true)
            {
                Console.Write("Enter the number of rows for the box: ");
                numberOfRows = Convert.ToInt32(Console.ReadLine());

                if (numberOfRows > 0)
                {
                    break;
                }

                Console.WriteLine("Error: The number of rows must be greater than 0");
                Console.WriteLine();
            }

            int numberOfColumns = 0;

            while (true)
            {
                Console.Write("Enter the number of columns for the box: ");
                numberOfColumns = Convert.ToInt32(Console.ReadLine());

                if (numberOfColumns > 0)
                {
                    break;
                }

                Console.WriteLine("Error: The number of columns must be greater than 0");
            }

            Console.WriteLine("Printing the desired box...");
            Console.WriteLine();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.WriteLine("The following part of this program will rows of asterisks of increasing in size up to the given number");
            Console.WriteLine();

            int maxLength = 0;

            while (true)
            {
                Console.Write("Enter the length of the longest row: ");
                maxLength = Convert.ToInt32(Console.ReadLine());

                if (maxLength > 0)
                {
                    break;
                }

                Console.WriteLine("Error: The length of the longest row must be greater than 0");
                Console.WriteLine();
            }

            Console.WriteLine("Printing the desired rows...");
            Console.WriteLine();

            for (int i = 1; i <= maxLength; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}