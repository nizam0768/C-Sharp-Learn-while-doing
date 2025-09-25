class Program
{
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
    }
    
}