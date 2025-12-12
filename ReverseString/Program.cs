class Program     
{
     internal static void ReverseString(string s)
{

    string[] str = s.ToLower().Split(' ');
    foreach (string str2 in str) 
    {
        char[] charArray = str2.ToCharArray();
        string rev = "";
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            rev += charArray[i];
        }
        Console.Write(rev);
    }
}
    static void Main(string[] args)
    {
        string input = "My Name is Khan";
        string reversed = "";
        for (int i = input.Length-1; i>=0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine("Orignam String: " + input);
        Console.WriteLine("Reversed String:" + reversed);

        Console.WriteLine("---------------------------------------");

        string str = "I am Learning C Sharp";
        string[] strSplit = str.Split(' ');
        string[] revString = new string[strSplit.Length];
        int x = 0;
        foreach (string s in strSplit)
        {
            char[] strWord = s.ToCharArray();
            Array.Reverse(strWord);
            string revWord = new string(strWord);
            revString[x] = revWord;
            x++;
        }
        string rev = string.Join(" ", revString);
        Console.WriteLine(rev);
        ReverseString(input); //Easy way to reverse by word.
    }
    
}
