using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Acme.StringCalculator.Tests
{
	[TestClass]
	public class IntegerParserTests
	{
		private IntegerParser _sut;

		private IntegerParser CreateIntegerParser()
		{
			return new IntegerParser();
		}

		[TestInitialize]
		public void SetupPerTest()
		{
			_sut = CreateIntegerParser();
		}

		[TestMethod]
		public void Parse_SingleElement_ReturnsListWithThatElement()
		{
			_sut.Parse("42").Should().BeEquivalentTo(new List<int> { 42 });
		}
	}
}
