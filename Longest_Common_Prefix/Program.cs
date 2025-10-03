class Program
{
    public string LongestCommonPrefix(string[] str)
    {
        if (str == null || str.Length == 0)
            return "";
        string prefix = str[0];
        for (int i = 1; i < str.Length; i++)
        {
            while (!str[i].StartsWith(prefix))
            {
                prefix = str[i].Substring(0, str.Length - 1);
                if(string.IsNullOrWhiteSpace(prefix))
                {
                    return "";
                }
            }
        }
        return prefix;
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        string[] str = { "flower", "flow", "flight" };

        string comm_Prefix = program.LongestCommonPrefix(str);

        Console.WriteLine(comm_Prefix);
    }
}