using System.Collections.Generic;
using Solution.Solve;
using Xunit;


namespace Solution.Tests
{
	public sealed class Tests
	{
		public sealed record Result(long Count, long Min, long Max);
		public sealed record Params(int SumDigits, int NumDigits);
	
	
		[Theory]
		[MemberData(nameof(ExampleTestsData))]
		public void ExampleTests(Result expected, Params args)
		{
			var result = Main.FindAll(args.SumDigits, args.NumDigits);
		
			Assert.Equal(expected, new(result[0], result[1], result[2]));
		}


		public static IEnumerable<object[]> ExampleTestsData()
		{
			yield return new object[]
			{
				new Result(8L, 118L, 334L),
				new Params(10, 3)
			};
		
			yield return new object[]
			{
				new Result(1L, 999L, 999L),
				new Params(27, 3)
			};

			yield return new object[]
			{
				new Result(123L, 116999L, 566666L),
				new Params(35, 6)
			};
		}
	}
}


