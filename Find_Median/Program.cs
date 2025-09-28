class Program
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;
        int[] arr = new int[m + n];
        int i = 0, j = 0, k = 0;
        // Merge both arrays
        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                arr[k++] = nums1[i++];
            }
            else
            {
                arr[k++] = nums2[j++];
            }
        }
        while (i < m) arr[k++] = nums1[i++];
        while (j < n) arr[k++] = nums2[j++];

        // Find Median
        int len = arr.Length;
        if (len % 2 == 1)
        {
            return arr[len / 2]; // odd length
        }
        else
        {
            return (arr[len / 2 - 1] + arr[len / 2]) / 2.0; // even
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();

        int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] nums2 = { 3, 7, 8, 9, 10, 11, 12, 13 };

        var median = program.FindMedianSortedArrays(nums1, nums2);

        Console.WriteLine("Median " + median);
    }
}