var a = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
var b = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();

var result = CompareTriplets(a, b);

foreach (var r in result)
{
    Console.Write(r);
    Console.Write(" ");
}

static List<int> CompareTriplets(List<int> a, List<int> b)
{
    var result = new List<int>() { 0, 0 };
    var count = a.Count;

    for (int i = 0; i < count; i++)
    {
        if (a[i] > b[i])
        {
            result[0] += 1;
        }
        else if (a[i] < b[i])
        {
            result[1] += 1;
        }
    }

    return result;
}