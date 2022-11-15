﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:4.0.0.0
//      SpecFlow Generator Version:4.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EnumDescriptionStepArgumentTransformer1.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Enumeration handling plug-in")]
    public partial class EnumerationHandlingPlug_InFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Enumeration handling plug-in", null, ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two base enum values")]
        public async System.Threading.Tasks.Task TwoBaseEnumValues()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two base enum values", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync("the first color is Red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                await testRunner.AndAsync("the second color is Blue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
                await testRunner.WhenAsync("the two numbers are added 1 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                await testRunner.ThenAsync("the result should be 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two descriptive enum values")]
        public async System.Threading.Tasks.Task TwoDescriptiveEnumValues()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Two descriptive enum values", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync("the first color is Magenta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                await testRunner.AndAsync("the second color is Navy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
                await testRunner.WhenAsync("the two numbers are added 2 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                await testRunner.ThenAsync("the result should be 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using a regular enum continues to work as it should")]
        public async System.Threading.Tasks.Task UsingARegularEnumContinuesToWorkAsItShould()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using a regular enum continues to work as it should", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync("a regular enum value of Big", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using a non-matching value should fail")]
        public async System.Threading.Tasks.Task UsingANon_MatchingValueShouldFail()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using a non-matching value should fail", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync("the first color is Green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to use descriptive enum values in tables")]
        [NUnit.Framework.TestCaseAttribute("Red", null)]
        [NUnit.Framework.TestCaseAttribute("Blue", null)]
        [NUnit.Framework.TestCaseAttribute("Magenta", null)]
        [NUnit.Framework.TestCaseAttribute("Navy", null)]
        public async System.Threading.Tasks.Task ShouldBeAbleToUseDescriptiveEnumValuesInTables(string color, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("color", color);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to use descriptive enum values in tables", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync(string.Format("the first color is {0}", color), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Demonstrate that quote text input also works")]
        public async System.Threading.Tasks.Task DemonstrateThatQuoteTextInputAlsoWorks()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Demonstrate that quote text input also works", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                await testRunner.GivenAsync("a color as", "Magenta", ((TechTalk.SpecFlow.Table)(null)), "Given ");
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
