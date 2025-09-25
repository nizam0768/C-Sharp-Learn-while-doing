class Program
{
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
        Console.WriteLine(missingNum);
    }
}