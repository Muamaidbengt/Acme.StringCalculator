using System.Linq;

namespace Acme.StringCalculator
{
    public class StringCalculator
    {
		private readonly IntegerAdder _adder;
		private readonly IntegerParser _parser;

		public StringCalculator(/* for sake of simplicity, do not add any constructor parameters */)
		{
			//... but feel free to initialize any dependencies here
			_adder = new IntegerAdder();
			_parser = new IntegerParser();
		}

		public int CalculateSum(string input)
		{
			var numbers = _parser.Parse(input);
			var sum = _adder.Add(numbers.First(), numbers.Last());
			return sum;
		}
    }
}
