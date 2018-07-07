#Feature: SpecFlowFeature
#	In order to avoid silly mistakes
#	As a math idiot
#	I want to be told the sum of two numbers

#@mytag
#Scenario: Add two numbers
	#Given I have entered 50 into the calculator
	#And I have entered 70 into the calculator
	#When I press add
	#Then the result should be 120 on the screen

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


#	Scenario: Display People page
#	Given I am on Octopus Investments people page of website
#	When I click on displayed image of person
#	Then I am presented with page dispalying that person details
