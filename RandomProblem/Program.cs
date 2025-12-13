class Program
{
    internal static Dictionary<int, List<string>> GetWordGroupByLength(string[] word)
    {
        Dictionary<int, List<string>> group = new Dictionary<int, List<string>>();
        foreach (string w in word)
        {
            int len = w.Length;
            if (!group.ContainsKey(len))
                group[len] = new List<string>();
            group[len].Add(w);
        }
        return group;
    }
    internal static Dictionary<char, int> GetCharacterOccurence(string str)
    {
        Dictionary<char, int> frq = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (frq.ContainsKey(c))
            {
                frq[c]++;
            }
            else
            {
                frq[c] = 1;
            }
        }
        return frq;
    }
    internal static bool IsPrime(int num)
    {
        if (num <= 0) return false;
        for (int i = 2; i * i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    internal static string FindSubString(string s, int startIndex, int length)
    {
        if (startIndex < 0 || length < 0 || startIndex + length > s.Length)
        {
            return "Wrong Input";
        }
        string subStr = s.Substring(startIndex, length);
        return subStr;
    }
    internal static bool IsPalindromeString(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        s = s.Replace(" ", "").ToLower();
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
    static void Main(string[] args)
    {
        string s = "Madam";
        bool result = IsPalindromeString(s);
        if (result)
        {
            Console.WriteLine($"String is palindrom {s}");
        }
        else { Console.WriteLine($"String is not palindrome {s}"); }
        string resultSub = FindSubString(s, 3, 2);
        Console.WriteLine(resultSub);
        bool resultPrime = IsPrime(11);
        Console.WriteLine($"Is Number Is Prime {resultPrime}");
        Dictionary<char, int> resultOccurenece = GetCharacterOccurence(s);
        foreach (var item in resultOccurenece)
        {

            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        foreach (char c in s)
        {
            if (resultOccurenece[c] == 1)
            {
                Console.WriteLine($"First non-repeating: {c}");
                break;
            }
            ;
        }
        string[] words = { "cat", "dog", "apple", "hi", "book" };
        Dictionary<int, List<string>> resultByGroup = GetWordGroupByLength(words);
        foreach (var word in resultByGroup)
        {
            Console.WriteLine($"{word.Key}: {string.Join(",", word.Value)}");
        }
    }
}