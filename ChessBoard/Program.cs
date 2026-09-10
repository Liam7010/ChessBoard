namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    if ((row + column) % 2 == 0)
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
