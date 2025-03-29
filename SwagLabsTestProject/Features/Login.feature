Feature: Login to Swag Labs
  As a valid user
  I want to be able to login to Swag Labs
  So that I can buy products

Background:
	Given I open the Swag Labs website

@mytag
Scenario: Login with valid credentials
  Given I am on the login page
  When I enter valid credentials
  And I click the login button
  Then I should be taken to the products page

Scenario: Login with invalid credentials
  Given I am on the login page
  When I enter invalid credentials
  And I click the login button
  Then I should see an error message

Scenario: Login with locked out user
  Given I am on the login page
  When I enter locked out user credentials
  And I click the login button
  Then I should see an error message

Scenario: Login with standard user
  Given I am on the login page
  When I enter standard user credentials
  And I click the login button
  Then I should be taken to the products page

Scenario: Login with problem user
  Given I am on the login page
  When I enter problem user credentials
  And I click the login button
  Then I should see an error message

Scenario: Login with performance glitch user
  Given I am on the login page
  When I enter performance glitch user credentials
  And I click the login button
  Then I should see an error message

Scenario: Login with error user
  Given I am on the login page
  When I enter error user credentials
  And I click the login button
  Then I should see an error message

Scenario: Login with visual user
  Given I am on the login page
  When I enter visual user credentials
  And I click the login button
  Then I should see an error message