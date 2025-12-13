class Program
{
    static void Main(string[] args)
    {
        string s = "Visual C# Express";
        string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
        Console.WriteLine(s.Substring(7,1));
        Console.WriteLine(s.Replace("C#", "Basic"));
        Console.WriteLine(s.IndexOf("C"));

        Console.WriteLine("-------------------------------------------");

        System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

        for(int j = 0; j<sb.Length; j++)
        {
            if (System.Char.IsLower(sb[j]) == true)
            {
                sb[j] = System.Char.ToUpper(sb[j]);
            }
            else if (System.Char.IsUpper(sb[j]) == true)
            {
                sb[j] = System.Char.ToLower(sb[j]);
            }
        }
        string corrected = sb.ToString();
        Console.WriteLine(corrected);

        Console.WriteLine("---------------------------------------------");

        System.Text.StringBuilder sbe = new System.Text.StringBuilder("Rat: The ideal pet");
        sbe[0] = 'C';
        System.Console.WriteLine(sbe);

        Console.WriteLine("----------------------------------------------");

        int i = 0;
        string se = "108";
        bool result = int.TryParse(se, out i);
        Console.WriteLine(result);
    }

}