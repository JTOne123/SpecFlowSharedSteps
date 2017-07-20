﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowSharedSteps.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Master", SourceFile="Features\\MasterFeature.feature", SourceLine=0)]
    public partial class MasterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MasterFeature.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Master", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 2
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should execute scenario shared steps", SourceLine=3)]
        public virtual void ShouldExecuteScenarioSharedSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should execute scenario shared steps", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line 5
 testRunner.Given("Save 1 to scenario context master1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Given("I execute the steps of \'Shared Feature\'.\'Shared Steps 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I execute the steps of \'Shared Feature\'.\'Shared Steps 2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("Read master1 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("Read a1 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Read a2 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should execute feature background shared steps", SourceLine=14)]
        public virtual void ShouldExecuteFeatureBackgroundSharedSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should execute feature background shared steps", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line 16
 testRunner.Given("I execute background steps of \'Shared Feature\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should execute both background and shared scenario steps", SourceLine=17)]
        public virtual void ShouldExecuteBothBackgroundAndSharedScenarioSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should execute both background and shared scenario steps", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line 19
 testRunner.Given("I execute background steps of \'Shared Feature\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("I execute the steps of \'Shared Feature\'.\'Shared Steps 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should execute scenario hierarchy", SourceLine=21)]
        public virtual void ShouldExecuteScenarioHierarchy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should execute scenario hierarchy", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line 23
 testRunner.Given("I execute the steps of \'Master\'.\'Should execute scenario shared steps\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.Then("Read master1 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("Read a1 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("Read a2 from scenario context", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Should execute shared steps from the table", SourceLine=27)]
        public virtual void ShouldExecuteSharedStepsFromTheTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should execute shared steps from the table", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "feature",
                        "scenario"});
            table1.AddRow(new string[] {
                        "Shared Feature",
                        "Shared Steps 1"});
            table1.AddRow(new string[] {
                        "Shared Feature",
                        "Shared Steps 2"});
#line 29
 testRunner.Given("I execute the steps of:", ((string)(null)), table1, "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion