﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
// Generation customised by SpecFlow.Contrib.Variants v3.9.90-pre.1
namespace SwagLabsTestProject.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login to Swag Labs")]
    [NUnit.Framework.CategoryAttribute("﻿")]
    [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
    [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
    public partial class LoginToSwagLabsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Login to Swag Labs", "  As a valid user\r\n  I want to be able to login to Swag Labs\r\n  So that I can buy" +
                    " products", ProgrammingLanguage.CSharp, new string[] {
                        "﻿",
                        "Browser:Chrome",
                        "Browser:Firefox"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("I open the Swag Labs website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with valid credentials: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void LoginWithValidCredentials_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with valid credentials: Chrome", null, new string[] {
                        "mytag"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with valid credentials: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void LoginWithValidCredentials_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with valid credentials: Firefox", null, new string[] {
                        "mytag"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute("invalid_user", "wrong_pass", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"invalid_user\", \"wrong_pass\"")]
        [NUnit.Framework.TestCaseAttribute("invalid_user", "wrong_pass", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"invalid_user\", \"wrong_pass\"")]
        [NUnit.Framework.TestCaseAttribute("user!@#", "secret_sauce", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"user!@#\", \"secret_sauce\"")]
        [NUnit.Framework.TestCaseAttribute("user!@#", "secret_sauce", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"user!@#\", \"secret_sauce\"")]
        [NUnit.Framework.TestCaseAttribute("user_with_very_long_username_exceeding_limit", "secret_sauce", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"user_with_very_long_username_exceedi" +
            "ng_limit\", \"secret_sauce\"")]
        [NUnit.Framework.TestCaseAttribute("user_with_very_long_username_exceeding_limit", "secret_sauce", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"user_with_very_long_username_exceed" +
            "ing_limit\", \"secret_sauce\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "short", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"standard_user\", \"short\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "short", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"standard_user\", \"short\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "password_with_special_chars!@#", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"standard_user\", \"password_with_speci" +
            "al_chars!@#\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "password_with_special_chars!@#", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"standard_user\", \"password_with_spec" +
            "ial_chars!@#\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "password with spaces", "Chrome", null, Category="Browser:Chrome", TestName="LoginWithInvalidCredentials with Chrome and \"standard_user\", \"password with space" +
            "s\"")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "password with spaces", "Firefox", null, Category="Browser:Firefox", TestName="LoginWithInvalidCredentials with Firefox and \"standard_user\", \"password with spac" +
            "es\"")]
        public virtual void LoginWithInvalidCredentials(string username, string password, string browser, string[] exampleTags)
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(string.Format("{0}: {1}", "Login with invalid credentials", browser), null, exampleTags, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", browser);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When(string.Format("I enter username \"{0}\"", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And(string.Format("I enter password \"{0}\"", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Username and password do not match a" +
                    "ny user in this service\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with missing password: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithMissingPassword_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with missing password: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter username \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Password is required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with missing password: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithMissingPassword_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with missing password: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter username \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Password is required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with missing username: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithMissingUsername_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with missing username: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter password \"secret_sauce\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Username is required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with missing username: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithMissingUsername_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with missing username: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter password \"secret_sauce\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Username is required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with locked out user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithLockedOutUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with locked out user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"locked_out_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Sorry, this user has been locked out" +
                    ".\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with locked out user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithLockedOutUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with locked out user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"locked_out_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should see an error message \"Epic sadface: Sorry, this user has been locked out" +
                    ".\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with standard user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithStandardUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with standard user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with standard user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithStandardUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with standard user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"standard_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with problem user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithProblemUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with problem user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"problem_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("All product should have an incorrect image path \"/static/media/sl-404.168b1cce.jp" +
                    "g\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with problem user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithProblemUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with problem user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"problem_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("All product should have an incorrect image path \"/static/media/sl-404.168b1cce.jp" +
                    "g\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with performance glitch user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithPerformanceGlitchUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with performance glitch user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"performance_glitch_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with performance glitch user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithPerformanceGlitchUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with performance glitch user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"performance_glitch_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with error user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithErrorUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with error user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"error_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with error user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithErrorUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with error user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"error_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with visual user: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void LoginWithVisualUser_Chrome()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with visual user: Chrome", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"visual_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("The cart icon should be in the wrong place", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("One product should have an incorrect image path \"/static/media/sl-404.168b1cce.jp" +
                    "g\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with visual user: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void LoginWithVisualUser_Firefox()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with visual user: Firefox", null, ((string[])(null)), argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.Given("I am on the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I enter credentials \"visual_user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("I should be taken to the products page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("The cart icon should be in the wrong place", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("One product should have an incorrect image path \"/static/media/sl-404.168b1cce.jp" +
                    "g\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
