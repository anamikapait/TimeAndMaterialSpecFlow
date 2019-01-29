
Feature: TimeAndMaterial
    As a logged in user in the Turnup portal
    I want successfully
    add, edit and delete Time and Materiel 

@mytag
Scenario Outline: Add time and material from specflow feature file
    Given I login with "<username>" and "<password>"
    When I have navigated to the Time and Material Page
    Then I have added new Time and Material successfully
Examples: 
| username | password |
| hari     | 123123   | 
    
Scenario: Logged in user should be able to Edit any Time and Material
    Given I have logged into the portal
    When I have navigated to the Time and Material Page
    Then I have edited the first Time and Material Successfully
     
     
Scenario: Logged in user should be able to Delete any Time and Material 
    Given I have logged into the portal
    When I have navigated to the Time and Material Page
    Then I have deleted one Time and Material successfully 
           
           