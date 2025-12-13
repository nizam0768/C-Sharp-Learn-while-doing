class Program
{
    static void Main(String[] args)
    {
        int[] numbers = { 10, 35, 20, 50, 40 };
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int num in numbers) { 
            if(num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if(num > secondLargest && num != largest) {
                secondLargest = num;
            }
        }
        Console.WriteLine("Second Largest {0}", secondLargest);
    }
}