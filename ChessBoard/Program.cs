namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int size = Convert.ToInt32(Console.ReadLine());// converts number to readable input
            Console.OutputEncoding = System.Text.Encoding.UTF8; // displays the chessboard symbols correctly

            // nested for loop to create the chessboard pattern
            for (int row = 0; row < size; row++) // outer loop for rows
            {
                for (int column = 0; column < size; column++)// inner loop for columns
                {
                    if ((row + column) % 2 == 0) // checks if the sum of row and column is even
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }

                Console.WriteLine();
            }

        }

    }
}
