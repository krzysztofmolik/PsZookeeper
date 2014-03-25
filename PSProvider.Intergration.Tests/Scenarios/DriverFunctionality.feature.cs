﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Zookeeper.PSProvider.Intergration.Tests.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DriverFunctionality")]
    public partial class DriverFunctionalityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DriverFunctionality.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DriverFunctionality", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
#line 3
#line 4
 testRunner.Given("I have registered SnapIn from assembly \'Zookeeper.PSProvider\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("I have Powershell host", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("Powershell add following script \'Add-PSSnapin ZookeeperPSSnap\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("Powershell add following script \'New-PSDrive -Name Zookeeper -PSProvider Zookeeep" +
                    "er -Root /\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("Powershell add following script \'cd Zookeeper:\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I have zookeeper client connected to \'127.0.0.1:2181\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I clear zookeeper configuration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Powershell execute scheduled commands", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\'ls\' should return all items in path")]
        public virtual void LsShouldReturnAllItemsInPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\'ls\' should return all items in path", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table1.AddRow(new string[] {
                        "zookeeper"});
#line 14
 testRunner.Then("Executing script \'(ls).Name\' should return following items", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\'cd\' should change current dictionary")]
        public virtual void CdShouldChangeCurrentDictionary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\'cd\' should change current dictionary", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 19
 testRunner.When("Powershell execute following script \'cd zookeeper\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table2.AddRow(new string[] {
                        "quota"});
#line 20
 testRunner.Then("Executing script \'(ls).Name\' should return following items", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table3.AddRow(new string[] {
                        "Zookeeper:\\zookeeper"});
#line 23
 testRunner.Then("Executing script \'$pwd.Path\' should return following items", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("new-item should create new item")]
        public virtual void New_ItemShouldCreateNewItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("new-item should create new item", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 28
 testRunner.When("Powershell execute following script \'New-Item -name Test -ItemType Node -Value \"T" +
                    "est\"\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table4.AddRow(new string[] {
                        "Test"});
            table4.AddRow(new string[] {
                        "zookeeper"});
#line 29
 testRunner.Then("Executing script \'(ls).Name\' should return following items", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get-Item should return data and stat for item")]
        public virtual void Get_ItemShouldReturnDataAndStatForItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get-Item should return data and stat for item", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 35
 testRunner.When("Powershell execute following script \'New-Item -name Test -ItemType Node -Value Te" +
                    "stValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table5.AddRow(new string[] {
                        "True"});
#line 36
 testRunner.Then("Executing script \'(Get-Item -Path Test) -ne $null\' should return following items", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get-Content should return data using given encoding")]
        public virtual void Get_ContentShouldReturnDataUsingGivenEncoding()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get-Content should return data using given encoding", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 41
 testRunner.When("Powershell execute following script \'New-Item -name Test -ItemType Node -Value Te" +
                    "stValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table6.AddRow(new string[] {
                        "TestValue"});
#line 42
 testRunner.Then("Executing script \'Get-Content -Path Test -Encoding UTF8\' should return following " +
                    "items", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Set-Content with encoding should change data")]
        public virtual void Set_ContentWithEncodingShouldChangeData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set-Content with encoding should change data", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 46
 testRunner.When("Powershell execute following script \'New-Item -name Test -ItemType Node -Value Te" +
                    "stValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.And("Powershell execute following script \'Set-Content -Path Test -Encoding UTF8 -Value" +
                    " TestValue2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table7.AddRow(new string[] {
                        "TestValue2"});
#line 48
 testRunner.Then("Executing script \'Get-Content -Path Test -Encoding UTF8\' should return following " +
                    "items", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sub folders should work fine")]
        public virtual void SubFoldersShouldWorkFine()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sub folders should work fine", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 53
 testRunner.When("Powershell execute following script \'New-Item -name Test -ItemType Node -Value Te" +
                    "stValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.And("Powershell execute following script \'cd Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And("Powershell execute following script \'New-Item -name SubTest -ItemType Node -Value" +
                    " SubTestValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table8.AddRow(new string[] {
                        "SubTestValue"});
#line 56
 testRunner.Then("Executing script \'Get-Content SubTest -Encoding UTF8\' should return following ite" +
                    "ms", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create new item in sub folder")]
        public virtual void CreateNewItemInSubFolder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create new item in sub folder", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 61
 testRunner.When("Powershell execute following script \'New-Item -name Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("Powershell execute following script \'New-Item -name SubTest -Path .\\Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table9.AddRow(new string[] {
                        "SubTest"});
#line 63
 testRunner.Then("Executing script \'(ls .\\Test).Name\' should return following items", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get-ChildItem with wild card")]
        public virtual void Get_ChildItemWithWildCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get-ChildItem with wild card", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 69
 testRunner.When("Powershell execute following script \'New-Item -name Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table10.AddRow(new string[] {
                        "True"});
#line 70
 testRunner.Then("Executing script \'(ls Tes*) -ne $null\' should return following items", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get-ChildItem -Recurse should retrun elements Recurse")]
        public virtual void Get_ChildItem_RecurseShouldRetrunElementsRecurse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get-ChildItem -Recurse should retrun elements Recurse", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 75
 testRunner.When("Powershell execute following script \'New-Item -name Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.When("Powershell execute following script \'New-Item -name SubTest -Path .\\Test\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.When("Powershell execute following script \'New-Item -name SubSubTest1 -Path .\\Test\\SubT" +
                    "est\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.When("Powershell execute following script \'New-Item -name SubSubTest2 -Path .\\Test\\SubT" +
                    "est\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table11.AddRow(new string[] {
                        "SubTest"});
            table11.AddRow(new string[] {
                        "SubSubTest2"});
            table11.AddRow(new string[] {
                        "SubSubTest1"});
#line 79
 testRunner.Then("Executing script \'Get-ChildItem -Recurse -Path Tes*\' should return following item" +
                    "s", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get-ChildItem -Recurse without path should retrun elements Recurse")]
        public virtual void Get_ChildItem_RecurseWithoutPathShouldRetrunElementsRecurse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get-ChildItem -Recurse without path should retrun elements Recurse", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 86
 testRunner.When("Powershell execute following script \'New-Item -name Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("Powershell execute following script \'New-Item -name SubTest -Path .\\Test\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item"});
            table12.AddRow(new string[] {
                        "/"});
            table12.AddRow(new string[] {
                        "Test"});
            table12.AddRow(new string[] {
                        "SubTest"});
            table12.AddRow(new string[] {
                        "zookeeper"});
            table12.AddRow(new string[] {
                        "quota"});
#line 88
 testRunner.Then("Executing script \'(Get-ChildItem -Recurse).Name\' should return following items", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
