Feature: TestAPI

A short summary of the feature

@QA_PipeLine
@case=01
Scenario:TC_01 Get all objects
    Given I make a GET request to retrieve all objects
    Then the response status code should be 200

@QA_PipeLine
@case=02
  Scenario:TC_02 Get object by ID
    Given I make a GET request for object with id "123"
    Then the response status code should be 200

@QA_PipeLine
@case=03
  Scenario:TC_03 Create a new object
    Given I make a POST request to create a new object
    And the response status code should be 201