﻿@Browser:Chrome
@Browser:Firefox
#@Browser:Edge
Feature: Login to Swag Labs
  As a valid user
  I want to be able to login to Swag Labs
  So that I can buy products

Background:
	Given I open the Swag Labs website

@mytag
Scenario: Login with valid credentials
  Given I am on the login page
  When I enter credentials "standard_user"
  And I click the login button
  Then I should be taken to the products page

Scenario Outline: Login with invalid credentials
  Given I am on the login page
  When I enter username "<username>"
	* I enter password "<password>"
  And I click the login button
  Then I should see an error message "Epic sadface: Username and password do not match any user in this service"

Examples:
	| username          | password     |
	| invalid_user    | wrong_pass | // Incorrect password
	| user!@#      | secret_sauce |  // Username with special characters
	| user_with_very_long_username_exceeding_limit | secret_sauce |  // Excessively long username
	| standard_user   | short     |  // Password too short
	| standard_user   | password_with_special_chars!@# |  // Password with special characters
	| standard_user  | password with spaces  |  // Password with trailing spaces

Scenario: Login with missing password
  Given I am on the login page
  When I enter username "standard_user"
  And I click the login button
  Then I should see an error message "Epic sadface: Password is required"

Scenario: Login with missing username
  Given I am on the login page
  When I enter password "secret_sauce"
  And I click the login button
  Then I should see an error message "Epic sadface: Username is required"

Scenario: Login with locked out user
  Given I am on the login page
  When I enter credentials "locked_out_user"
  And I click the login button
  Then I should see an error message "Epic sadface: Sorry, this user has been locked out."

Scenario: Login with standard user
  Given I am on the login page
  When I enter credentials "standard_user"
  And I click the login button
  Then I should be taken to the products page

Scenario: Login with problem user
  Given I am on the login page
  When I enter credentials "problem_user"
  And I click the login button
  Then All product should have an incorrect image path "/static/media/sl-404.168b1cce.jpg"

Scenario: Login with performance glitch user
  Given I am on the login page
  When I enter credentials "performance_glitch_user"
  And I click the login button
  Then I should be taken to the products page

Scenario: Login with error user
  Given I am on the login page
  When I enter credentials "error_user"
  And I click the login button
  Then I should be taken to the products page

Scenario: Login with visual user
  Given I am on the login page
  When I enter credentials "visual_user"
  And I click the login button
  Then I should be taken to the products page
  And The cart icon should be in the wrong place
  And One product should have an incorrect image path "/static/media/sl-404.168b1cce.jpg"