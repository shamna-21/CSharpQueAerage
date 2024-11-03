namespace AverageInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integers separated by spaces:");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);
            Program prog = new Program();
            double avg = prog.Average(arr);
            Console.WriteLine($"average is {avg}");
        }
        public double Average(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return (double)sum / arr.Length;
        }

    }
}

