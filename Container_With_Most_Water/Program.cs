class Program
{
    public int MaxArea(int[] Height)
    {
        int left = 0, right = Height.Length - 1;
        int maxArea = 0;

        while(left < right)
        {
            int width = right - left;
            int h = Math.Min(Height[left], Height[right]);
            int area = h * width;
            maxArea = Math.Max(maxArea, area);

            // Move the pointer pointing to the smaller line

            if (Height[left] < Height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int MaxArea = program.MaxArea(height);
        Console.WriteLine("Container With Most Water " + MaxArea);
    }
}