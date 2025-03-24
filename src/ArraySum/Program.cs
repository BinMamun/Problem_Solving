var arCount = Convert.ToInt32(Console.ReadLine()?.Trim());

var ar = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

if (ar is not null)
{
    var result = SimpleArraySum(ar);
    Console.WriteLine(result);
}

static int SimpleArraySum(List<int> ar)
{
    return ar.Sum();
}

