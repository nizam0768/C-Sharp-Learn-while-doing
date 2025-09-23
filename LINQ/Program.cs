namespace LINQ
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
            Console.WriteLine("--------------------------------------");

            List<string> names = new List<string>() { "Ali", "Nizam", "Nancy", "Muskan", "Kriti", "Kathy" };
            var filteredNames = names.Where(name => name.StartsWith("K"));
            Console.WriteLine("Names starting with A:");
            foreach(var name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
/*
 * It’s a powerful feature that lets you query data (from collections, databases, XML, etc.) using a SQL-like syntax directly inside C# code.
 * It integrates queries into the C# language itself, so you can filter, sort, group, and transform data in a strongly typed, compiler-checked way.
 */

/*
 * Works with in-memory collections (List, Array), databases (Entity Framework), XML, etc.
 * Provides declarative syntax (like SQL) and method syntax (using extension methods like .Where(), .Select()).
 * Strongly typed → compiler checks your query expressions.
 */