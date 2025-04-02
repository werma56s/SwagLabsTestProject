﻿@Browser:Chrome
@Browser:Firefox
#@Browser:Edge
Feature: Checkout Process Validation

  Requirement: The system must ensure that users provide necessary information during checkout to proceed.

  Background:
	Given I open the Swag Labs website
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User clicks on the "Add to cart" button of a product "Sauce Labs Bike Light"
    And User navigates to the cart page

  Scenario: User cannot proceed without providing First Name
    Requirement: The system must display an error message if the First Name field is left empty.
    Given the user click the checkout button
    When they enter "empty" in the First Name field
    And they enter "random.lastname" in the Last Name field
    And they enter "random.zipcode" in the Zip Code field
    And they click the Continue button
    Then they should see an error message "Error: First Name is required"

  Scenario: User cannot proceed without providing Last Name
    Requirement: The system must display an error message if the Last Name field is left empty.
    Given the user click the checkout button
    When they enter "random.firstname" in the First Name field
    And they enter "empty" in the Last Name field
    And they enter "random.zipcode" in the Zip Code field
    And they click the Continue button
    Then they should see an error message "Error: Last Name is required"

  Scenario: User cannot proceed without providing Zip Code
    Requirement: The system must display an error message if the Zip Code field is left empty.
    Given the user click the checkout button
    When they enter "random.firstname" in the First Name field
    And they enter "random.lastname" in the Last Name field
    And they enter "empty" in the Zip Code field
    And they click the Continue button
    Then they should see an error message "Error: Postal Code is required"

  Scenario: User successfully completes the checkout form
    Requirement: The system must allow the user to proceed to the checkout overview page if all required fields are filled.
    Given the user click the checkout button
    When they enter "random.firstname" in the First Name field
    And they enter "random.lastname" in the Last Name field
    And they enter "random.zipcode" in the Zip Code field
    And they click the Continue button
    Then they should see Price Total "Total: $10.79"

 Scenario: User successfully buys a product
    Requirement: The system must allow the user to complete the purchase and display a confirmation message.
    Given the user click the checkout button
    When they enter "random.firstname" in the First Name field
    And they enter "random.lastname" in the Last Name field
    And they enter "random.zipcode" in the Zip Code field
    And they click the Continue button
    And they click the Finish button
    Then they should see the messages "Thank you for your order!" and "Your order has been dispatched, and will arrive just as fast as the pony can get there!"
    And they should see the "Back Home" button