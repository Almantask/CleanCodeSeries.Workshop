using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CleanCodeSeries.Workshop.Lesson8.BDD
{
    [Binding]
    public class GreeterSteps
    {
        private string _result;
        private readonly Greeter _greeter = new Greeter();

         // _greeter.Language = Language.EN;
         // _result = _greeter.Greet(name);
         // Assert.Equal(greet, _result);


        [Given(@"I have selected a language EN,")]
        public void GivenIHaveSelectedALanguageEN()
        {
            _greeter.Language = Language.EN;
        }
        
        [When(@"I greet a person with a name ""(.*)"",")]
        public void WhenIGreetAPersonWithAName(string p0)
        {
            _result = _greeter.Greet(p0);
        }
        
        [Then(@"the result should be ""(.*)""\.")]
        public void ThenTheResultShouldBe_(string p0)
        {
            Assert.Equal(_result, p0);
        }
    }
}
