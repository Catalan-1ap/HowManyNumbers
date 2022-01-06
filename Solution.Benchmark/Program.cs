using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Solution.Solve;


namespace Solution.Benchmark
{
	internal class Program
	{
		private static void Main(string[] args) => BenchmarkRunner.Run<Benchy>();
	}


	[MemoryDiagnoser]
	public class Benchy
	{
		[Benchmark]
		public void Overall() => Main.FindAll(42, 12);
	}
}