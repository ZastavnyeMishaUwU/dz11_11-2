namespace dz11_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 12, 25, 33, 18, 40 };
            int minRange = 10;
            int maxRange = 30;

            Console.Write("Числа в діапазоні 10-30: ");
            bool first = true;

            foreach (int number in array)
            {
                if (number >= minRange && number <= maxRange)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(number);
                    first = false;
                }
            }

            Console.WriteLine();
        }
    }
}
