Feature: People page functionality 
	In order to validate people page 
	As a tester 
	I want to check the search functionality of people

@SmokeTest
@Browser:Chrome
	Scenario: People page feature validation
	In order to validate the people page
	of Octopus investment website
	I want to display people page

	Scenario: Display People page
	Given I am on Octopus Investments Homepage of website
	When I click on About Us
	And I click on View our People button
	Then I am presented with our people 
