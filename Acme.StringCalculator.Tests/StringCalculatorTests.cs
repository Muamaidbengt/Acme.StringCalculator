using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.StringCalculator.Tests
{
	[TestClass]
	public class StringCalculatorTests
	{
		private StringCalculator _sut;

		private StringCalculator CreateStringCalculator()
		{
			return new StringCalculator();
		}

		[TestInitialize]
		public void SetupPerTest()
		{
			_sut = CreateStringCalculator();
		}

		[TestMethod]
		public void CalculateSum_TwoSmallPositiveNumbers_ReturnsSumOfThem()
		{
			_sut.CalculateSum("2,2").Should().Be(4);
		}

		[TestMethod]
		public void CalculateSum_EmptyString_ReturnsZero()
		{
			_sut.CalculateSum(string.Empty).Should().Be(0);
		}

		// TODO: More test cases!
	}
}
