namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            // Using LINQ to filter even numbers
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;

            Console.WriteLine(numbers);
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
