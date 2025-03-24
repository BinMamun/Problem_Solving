var n = int.Parse(Console.ReadLine());

var matrix = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    matrix.Add(Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList());
    Console.WriteLine();
}

Console.WriteLine(DiagonalDifference(matrix));

static int DiagonalDifference(List<List<int>> arr)
{
    var length = arr.Count - 1;
    int leftToRight = 0, rightToLeft = 0;

    for (int i = 0; i <= length; i++)
    {
        leftToRight += arr[i][i];
        rightToLeft += arr[i][length - i];
    }

    var absoluteDiff = leftToRight - rightToLeft;

    return Math.Abs(absoluteDiff);
}