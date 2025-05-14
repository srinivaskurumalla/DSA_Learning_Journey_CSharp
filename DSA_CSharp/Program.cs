using DSA_CSharp.Arrays.Problems;

public class Program
{
    static void Main(string[] args)
    {
        ArrayCoding ac = new ArrayCoding();
        int res = ac.LongestSubarraySumEqualsK(new[] { 1, -1, 5, -2, 3 }, 3);
        Console.WriteLine( res);
    }
}