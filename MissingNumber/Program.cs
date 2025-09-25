class Program
{
    //If multiple numbers are missing
    public List<int> FindMissingElements(int[] arr, int n)
    {
        var present = new HashSet<int>(arr);
        var missing = new List<int>();
        for(int i = 1; i<=n; i++)
        {
            if(!present.Contains(i))
            {
                missing.Add(i);
            }
        }
        return missing;
    }
    public int MissingNumber(int[] array, int n)
    {
        // Get the some n natural number 
        int total = n * (n + 1) / 2;
        int actualSum = 0;
        //calculate sum of array elements
        foreach (int num in array)
        {
            actualSum += num;
        }
        return total- actualSum;
    }
     static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 5};
        Program p = new Program();
        int missingNum = p.MissingNumber(arr, 5);
        Console.WriteLine("---------------Single Element Missing-----------------");
        Console.WriteLine(missingNum);

        int[] arr2 = { 1, 2, 4, 6, 7, 9 };
        List<int> multipleMissing = p.FindMissingElements(arr2, 8);
        Console.WriteLine("--------------------Multiple Element Missing-----------------");
        foreach(int num in multipleMissing)
        {
            Console.WriteLine(num);
        }
    }
}