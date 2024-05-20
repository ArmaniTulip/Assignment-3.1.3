namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();

            int spaces = SpaceCounter(stringInput);

            Console.WriteLine(spaces);
        }

        public static int SpaceCounter(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ' ') count++;
            }
            return count;
        }

    }
}
