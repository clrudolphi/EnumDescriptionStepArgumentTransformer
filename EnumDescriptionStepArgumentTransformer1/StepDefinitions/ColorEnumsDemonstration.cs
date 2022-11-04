namespace EnumDescriptionStepArgumentTransformer1.StepDefinitions
{
    [Binding]
    public sealed class ColorEnumsDemonstration
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first color is (.*)")]
        public void GivenTheFirstNumberIs(Colors first)
        {
    
        }

        [Given("the second color is (.*)")]
        public void GivenTheSecondNumberIs(Colors second)
        {

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
   
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
    }
}