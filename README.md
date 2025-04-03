# SwagLabsTestProject
The SwagLabsTestProject is an automated testing project for the Swag Labs website, built using Selenium WebDriver for browser automation and SpecFlow for BDD testing in C# and .NET 6. It supports cross-browser testing (Chrome, Firefox, Edge), employs the Page Object Model (POM) for maintainable tests, and integrates Faker.Data for dynamic test data. The project also utilizes Docker and Selenium Grid to run tests in isolated containers across multiple browsers, enabling efficient parallel execution and scalable test environments. Additionally, the project integrates GitHub Actions for Continuous Integration (CI), automating the process of building, testing, and deploying the application. GitHub Actions workflows are configured to run tests on every push or pull request to the main branch, ensuring that code changes are thoroughly tested in a consistent environment.
# Features
•	Automated tests for login functionality with various user types and credentials.  
•	Verification of UI elements and their properties.  
•	Cross-browser testing support for Chrome, Firefox, and Edge.  
•	Use of Page Object Model (POM) for better test maintenance and readability.  
•	Integration with NUnit for test execution and reporting. 
•	Integration with Faker.Data for generating dynamic fake data, useful for randomizing user credentials, names, and other data for login tests.  
• Dockerized environment for running Selenium tests on multiple browsers using Selenium Grid.  
# Technologies Used
•	.NET: 6.0  
•	Selenium WebDriver: 4.30.0  
•	Selenium Support: 4.30.0  
•	SpecFlow: 3.9.74 (SpecFlow.NUnit), 3.9.57 (SpecFlow.Plus.LivingDocPlugin), 3.9.90 (SpecFlow.Contrib.Variants)  
•	NUnit: 4.3.2  
•	NUnit3TestAdapter: 5.0.0  
•	FluentAssertions: 8.2.0   
•	Faker.Data: 2.0.1 For generating fake data such as random user credentials, email addresses, and more to support the login functionality tests.  
•	Selenium Grid: For cross-browser testing, often managed in Docker or via services in the CI pipeline.
•   Docker: For running Selenium Grid with multiple browser nodes.  
•   GitHub Actions: The core technology for automating workflows, enabling CI/CD processes directly within GitHub repositories.  
# Project Structure  
•	The .github/workflows/dotnet-desktop.yml file defines a CI workflow for a .NET application, including steps such as checking out code, starting Docker containers, setting up .NET SDK, building the application, running tests, and tearing down Docker containers.
•	Features: Contains the feature files written in Gherkin syntax.  
•	StepDefinitions: Contains the step definition classes that map Gherkin steps to C# methods.  
•	Pom: Contains the Page Object Model classes representing different pages of the Swag Labs application.  
•	Support: Contains support classes such as data providers and utility methods.  
•	Hook: Contains hooks for setting up and tearing down the WebDriver before and after each scenario.    
•	Drivers: Contains the WebDriverLibrary class responsible for setting up and managing the browser WebDriver instances. It supports cross-browser testing using Selenium Grid for parallel execution across browsers like Chrome, Firefox and Edge.
# Setup and Usage
1.	Clone the repository.
2.	Open the solution in Visual Studio 2022.
3.	Restore the NuGet packages.
4.	Build the solution.
5.	To run the tests, use the Test Explorer in Visual Studio or run the tests from the command line using the "dotnet test" command.
# Docker and Selenium Grid Setup

This project includes a Docker setup for running Selenium Grid with multiple browser nodes (Chrome, Firefox, Edge). This allows for parallel execution and cross-browser testing.

1. Docker Setup:
    A docker-compose.yml file is provided to configure and launch a Selenium Grid along with browser nodes for Chrome, Firefox, and Edge. The Selenium Hub and nodes are defined as services in Docker Compose.
2. Running the Docker Containers:
To start the Selenium Grid using Docker, run the following command from the root directory of the project where docker-compose.yml is located:

    docker compose up -p

  This will start the Selenium Hub and browser nodes (Chrome, Firefox, Edge) in detached mode.
  ![obraz](https://github.com/user-attachments/assets/0fb68605-a9e2-438c-8bf8-8597d94c544b)

3. Connect to Selenium Grid:
The tests will be executed on the Selenium Grid by connecting to the Hub (running on http://localhost:4444/). The WebDriver will automatically connect to the correct browser node depending on the tag specified in the feature files (e.g., @Browser:Chrome, @Browser:Firefox).
![obraz](https://github.com/user-attachments/assets/951cdf9d-05ba-4bc6-acba-e29d99f393e5)

5. Stop the Docker Containers:
To stop the containers, run:

    docker compose down

This setup ensures that tests can be run across multiple browsers in parallel using Docker and Selenium Grid, enabling efficient and scalable test execution.

