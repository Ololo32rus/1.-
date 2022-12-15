
int N, M, K;
Console.Write("n=");
N = int.Parse(Console.ReadLine());
Console.Write("m=");
M = int.Parse(Console.ReadLine());
Console.Write("k=");
K = int.Parse(Console.ReadLine());

if (N * M < K)
{ Console.WriteLine($"NO"); }
else
        { Console.WriteLine($"YES"); }