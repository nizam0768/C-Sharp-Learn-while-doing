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

            Console.WriteLine("----ToUpper()--------");

            var upperNames = names.Select(names => names.ToUpper());
            foreach(var name in upperNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------groupBy------------");

            var words = new List<string>() { "cat", "car", "bat", "ball", "rat", "run", "rackon", "beer","bull", "Horse", "Hippo", "Tiger" };
            var group = words.GroupBy(w => w[0]);
            foreach(var g in group)
            {
                Console.WriteLine($"Words starting with {g.Key}:");
                foreach(var w in g)
                {
                    Console.WriteLine(w);
                }
            }

            Console.WriteLine("---------------------");

            int[] scores = [97, 92, 81, 60];
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach(var i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("-----------------------------");

            int[] number = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var numQuery = number
                           .Where(num => num % 2 == 0 && num * num < 50)
                           .Select(num => num * num);
            foreach (var num in numQuery)
            {
                Console.Write($"{num} ");
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