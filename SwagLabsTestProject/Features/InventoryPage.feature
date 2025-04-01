﻿@Browser:Chrome
@Browser:Firefox
#@Browser:Edge
Feature: Inventory Page Functionality

Background:
	Given I open the Swag Labs website

  Scenario: User can see the list of products
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    Then I should be taken to the products page

  Scenario: User can add a product to the cart
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User clicks on the "Add to cart" button of a product "Sauce Labs Bike Light"
    Then The product should be added to the cart
    And The cart badge should show the correct item count

  Scenario: User can remove a product from the cart
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User clicks on the "Add to cart" button of a product "Sauce Labs Bike Light"
    When User clicks on the "Remove" button for that product "Sauce Labs Bike Light"
    And User navigates to the cart page
    Then The product should be removed from the cart
    And The cart badge should update correctly

  Scenario: User can see the total price of two products in the cart
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    And User clicks on the "Add to cart" button of a product "Sauce Labs Bike Light"
    And User clicks on the "Add to cart" button of a product "Sauce Labs Fleece Jacket"
    And User navigates to the cart page
	Then The cart should display exactly two products "Sauce Labs Bike Light" and "Sauce Labs Fleece Jacket"

  Scenario: User can sort products by price (low to high)
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User selects "Price (low to high)" from the sorting dropdown
    Then The products should be sorted from the lowest to the highest price

  Scenario: User can sort products by price (high to low)
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User selects "Price (high to low)" from the sorting dropdown
    Then The products should be sorted from the highest to the lowest price

  Scenario: User can sort products by Name (A to Z)
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User selects "Name (A to Z)" from the sorting dropdown
    Then The products should be sorted from the A to the Z name

  Scenario: User can sort products by Name (Z to A)
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User selects "Name (Z to A)" from the sorting dropdown
    Then The products should be sorted from the Z to the A name

  Scenario: User can log out successfully
    Given I am on the login page
    When I enter credentials "standard_user"
    And I click the login button
    When User clicks on the menu button
    And User selects the "Logout" option
    Then User should be redirected to the login page
