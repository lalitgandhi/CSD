Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given User enter "3,5,+"
	When I press add
	Then the result should be 8 on the screen
