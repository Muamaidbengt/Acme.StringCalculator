using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.StringCalculator.Tests
{
	[TestClass]
	public class IntegerAdderTests
	{
		private IntegerAdder _sut;

		private IntegerAdder CreateIntegerAdder()
		{
			return new IntegerAdder();
		}

		[TestInitialize]
		public void SetupPerTest()
		{
			_sut = CreateIntegerAdder();
		}

		[TestMethod]
		public void Add_TwoSmallPositiveNumbers_ReturnsSumOfThem()
		{
			_sut.Add(2, 2).Should().Be(4);
		}
	}
}
