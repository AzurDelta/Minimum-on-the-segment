


Console.Write("enter length and window width: ");
string result = Console.ReadLine();
var len = int.Parse(result.Split(' ', ',')[0]);
var width = int.Parse(result.Split(' ', ',')[1]);

Console.Write("enter querry: ");
result = Console.ReadLine();
List<int> ints = new();
result.Split(' ', ',')
      .ToList()
      .ForEach(x => ints.Add(int.Parse(x)));
       
var resultInts = MinimumOnTheSegment(ints, width);

foreach (var item in resultInts)
{
    Console.WriteLine(item);
}


int[] MinimumOnTheSegment(List<int> nIntns, int k)
{
    int[] intsOut = new int[nIntns.Count-k+1];
    
    for (int i = 0; i < intsOut.Length; i++)
    {
        intsOut[i] = nIntns.Skip(i).Take(k).Min();
    }
    return intsOut;
}