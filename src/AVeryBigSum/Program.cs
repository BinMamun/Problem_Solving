var n = int.Parse(Console.ReadLine());
var arr = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();

Console.WriteLine(AVeryBigSum(arr));

static long AVeryBigSum(List<long> ar)
{
    return ar.Sum();
}