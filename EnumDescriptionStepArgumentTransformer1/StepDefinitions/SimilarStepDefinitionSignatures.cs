using SpecFlowEnumIssue.Enum;

namespace SpecFlowEnumIssue.Steps;

[Binding]
public class SimilarStepDefinitionSignatures
{
    [When(@"I use step with {FirstDefinition} with closed signature")]
    public void WhenIUseStepWithDefinition(FirstDefinition similarFirstDefinition)
    {
    }

    [When(@"I use step with Similar {FirstDefinition} with closed signature")]
    public void WhenIUseStepWithSimilarDefinition(FirstDefinition firstDefinition)
    {
    }

    [When(@"I use step with '(.*)' with closed signature")]
    public void WhenIUseStepWithDefinitionRegex(FirstDefinition similarFirstDefinition)
    {
    }

    [When(@"I use step with Similar '(.*)' with closed signature")]
    public void WhenIUseStepWithSimilarDefinitionRegex(FirstDefinition firstDefinition)
    {
    }

}