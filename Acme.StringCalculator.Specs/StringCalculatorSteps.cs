using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace Acme.StringCalculator.Specs
{
    [Binding]
    public class StringCalculatorSteps
    {
		private string _errorMessage;
		private int? _result;
		private string _textEntered;
		private readonly StringCalculator _sut;

		public StringCalculatorSteps()
		{
			_sut = new StringCalculator();
		}


		[Given(@"I have entered (?s)(.*)(?-s) as text")]
        public void GivenIHaveEnteredNAsText(string someText)
        {
			_textEntered = someText;
        }
        
        [When(@"the calculator adds them")]
        public void WhenTheCalculatorAddsThem()
        {
			_result = _sut.CalculateSum(_textEntered);
        }
        
        [When(@"the calculator tries to add (?:it|them)")]
        public void WhenTheCalculatorTriesToAddIt()
        {
            try
			{
				WhenTheCalculatorAddsThem();
			}
			catch(Exception ex)
			{
				_errorMessage = ex.Message;
			}
        }
        
        [Then(@"the result should be (\d*)")]
        public void ThenTheResultShouldBeN(int expected)
        {
			_result.Should().Be(expected);
        }
        
        [Then(@"the result should be an error")]
        public void ThenTheResultShouldBeAnError()
        {
			_errorMessage.Should().NotBeNullOrEmpty();
        }
        
        [Then(@"the error message should explain that (.*) was invalid input")]
        public void ThenTheErrorMessageShouldExplainThatNWasInvalidInput(string invalid)
        {
			_errorMessage.Should().Contain(invalid);
        }
    }
}
