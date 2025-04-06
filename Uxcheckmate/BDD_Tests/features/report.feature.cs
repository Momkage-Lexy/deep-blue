﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD_Tests.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User enters in url and recieves analysis report")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class UserEntersInUrlAndRecievesAnalysisReportFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "features", "User enters in url and recieves analysis report", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "report.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
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
        [NUnit.Framework.DescriptionAttribute("David analyzes his site and views the results")]
        public async System.Threading.Tasks.Task DavidAnalyzesHisSiteAndViewsTheResults()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("David analyzes his site and views the results", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
    await testRunner.GivenAsync("David is on the homepage", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 6
    await testRunner.AndAsync("he enters his URL into the submission box", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 7
    await testRunner.AndAsync("he clicks the analyze button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 9
    await testRunner.ThenAsync("he will see a loading overlay", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 10
    await testRunner.AndAsync("he will be directed to the results view", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
    await testRunner.AndAsync("he will see a screenshot of the site", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 12
    await testRunner.AndAsync("he will see the site URL", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 13
    await testRunner.AndAsync("he will see how many issues his site has", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 14
    await testRunner.AndAsync("he will see a container for design issues with subrows of issues", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 15
    await testRunner.AndAsync("he will see a container for accessibility issues with subrows of issues", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
