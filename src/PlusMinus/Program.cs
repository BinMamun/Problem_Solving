var n = int.Parse(Console.ReadLine()?? string.Empty);

var arr = (Console.ReadLine()?? string.Empty).Split(' ').Select(int.Parse).ToList();

PlusMinus(arr);

static void PlusMinus(List<int> arr)
{
    var count = arr.Count;

	int positive = arr.Count(x => x > 0);
    int negative = arr.Count(x => x < 0);
    int zero = arr.Count(x => x == 0);


    foreach (var item in new List<int> { positive, negative, zero })
    {
        Console.WriteLine(((double)item / count).ToString("0.000000"));
    }
}