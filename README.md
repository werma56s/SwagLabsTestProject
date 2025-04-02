# SwagLabsTestProject
Description
SwagLabsTestProject is an automated testing project for the Swag Labs website. The project uses Selenium WebDriver and SpecFlow to perform end-to-end tests on the Swag Labs application. The tests are written in C# and target the .NET 6 framework.
# Features
•	Automated tests for login functionality with various user types and credentials.  
•	Verification of UI elements and their properties.  
•	Cross-browser testing support for Chrome, Firefox, and Edge.  
•	Use of Page Object Model (POM) for better test maintenance and readability.  
•	Integration with NUnit for test execution and reporting. 
•	Integration with Faker.Data for generating dynamic fake data, useful for randomizing user credentials, names, and other data for login tests.  
# Technologies Used
•	.NET: 6.0  
•	Selenium WebDriver: 4.30.0  
•	Selenium Support: 4.30.0  
•	SpecFlow: 3.9.74 (SpecFlow.NUnit), 3.9.57 (SpecFlow.Plus.LivingDocPlugin), 3.9.90 (SpecFlow.Contrib.Variants)  
•	NUnit: 4.3.2  
•	NUnit3TestAdapter: 5.0.0  
•	FluentAssertions: 8.2.0   
•	Faker.Data: 2.0.1 For generating fake data such as random user credentials, email addresses, and more to support the login functionality tests.  
# Project Structure  
•	Features: Contains the feature files written in Gherkin syntax.  
•	StepDefinitions: Contains the step definition classes that map Gherkin steps to C# methods.  
•	Pom: Contains the Page Object Model classes representing different pages of the Swag Labs application.  
•	Support: Contains support classes such as data providers and utility methods.  
•	Hook: Contains hooks for setting up and tearing down the WebDriver before and after each scenario.  
# Setup and Usage
1.	Clone the repository.
2.	Open the solution in Visual Studio 2022.
3.	Restore the NuGet packages.
4.	Build the solution.
5.	To run the tests, use the Test Explorer in Visual Studio or run the tests from the command line using the "dotnet test" command.
