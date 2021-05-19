@UItest
Feature: Navigation bar UI test
  @ToDoApp
  Scenario: Check blog page opening
    Given User has opened main page
    When User opens blog page
    Then Blog page opens
    And User sees Greetings, Innovators!

  @Test
  Scenario: Check how we do it button
    Given User has opened main page
    When User clicks how we do it button
    Then How we do it page opens

  @Test
  Scenario: Check change language
    Given User has opened main page
    When User clicks contact selection button
    And Choose ukrainian
    Then User see ukrainian main page

  @Test
  Scenario: Check contact us button
    Given User has opened main page
    When User clicks contact us button
    Then Contact page opens

  @Test
  Scenario: Check return to home page
    Given User has opened main page
    When User clicks how we do it button
    And User clicks home page button
    Then User backs to home page


  @Test
  Scenario: User searches blockchain
    Given User has opened main page
    Then User clicks search button
    And User writes Blockchain
    And User clicks find button
    Then User sees result
