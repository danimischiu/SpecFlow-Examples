// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecialChars.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SpecialCharsFeature : Xunit.IClassFixture<SpecialCharsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SpecialChars.feature"
#line hidden
        
        public SpecialCharsFeature(SpecialCharsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecialChars", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="From GitHub Issue 1221")]
        [Xunit.TraitAttribute("FeatureTitle", "SpecialChars")]
        [Xunit.TraitAttribute("Description", "From GitHub Issue 1221")]
        [Xunit.InlineDataAttribute("Å", new string[0])]
        [Xunit.InlineDataAttribute("ô", new string[0])]
        [Xunit.InlineDataAttribute("é", new string[0])]
        public virtual void FromGitHubIssue1221(string @char, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("From GitHub Issue 1221", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Then(string.Format("the special char \'{0}\' is working", @char), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="From GitHub Issue 1205")]
        [Xunit.TraitAttribute("FeatureTitle", "SpecialChars")]
        [Xunit.TraitAttribute("Description", "From GitHub Issue 1205")]
        [Xunit.InlineDataAttribute("á", new string[0])]
        [Xunit.InlineDataAttribute("ã", new string[0])]
        public virtual void FromGitHubIssue1205(string @char, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("From GitHub Issue 1205", null, exampleTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Then(string.Format("the special char \'{0}\' is working", @char), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Currency symbols")]
        [Xunit.TraitAttribute("FeatureTitle", "SpecialChars")]
        [Xunit.TraitAttribute("Description", "Currency symbols")]
        [Xunit.InlineDataAttribute("€", new string[0])]
        [Xunit.InlineDataAttribute("$", new string[0])]
        [Xunit.InlineDataAttribute("£", new string[0])]
        public virtual void CurrencySymbols(string @char, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Currency symbols", null, exampleTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Then(string.Format("the special char \'{0}\' is working", @char), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SpecialCharsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SpecialCharsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
