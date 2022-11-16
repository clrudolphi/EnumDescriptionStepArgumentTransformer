namespace EnumDescriptionStepArgumentTransformer1.StepDefinitions
{

    [Binding]
    public class RegularEnumBindingSteps
    {
        [Given(@"a regular enum value of (.*)")]
        public void GivenARegularEnumValueOfGreen(StandardEnum regularEnum)
        {
           
        }

    }

    [Binding]
    public sealed class ColorEnumsDemonstration
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first color is (.*)")]
        public void GivenTheFirstNumberIs(Colors first)
        {
    
        }

        [Given("the first color is (.*)")]
        public void GivenTheFirstNumberIs(Pastels first)
        {

        }


        [Given("the second color is (.*)")]
        public void GivenTheSecondNumberIs(Colors second)
        {

        }
        private int sum;
        [When("the two numbers are added (.*) (.*)")]
        public void WhenTheTwoNumbersAreAdded(int a, int b)
        {
            sum = a + b;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(sum);
        }

        [Given(@"a color as")]
        public void GivenAColorAs(Colors c)
        {
            
        }

    }
}