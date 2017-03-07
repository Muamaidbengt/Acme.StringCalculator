Feature: String Calculator
	As a math dimwit
	I want to enter numbers as text
	And have them added for me
	So I don't have to think so much

Scenario Outline: Calculator adds numbers separated by comma, ignoring space
	Given I have entered <numbers> as text
	When the calculator adds them
	Then the result should be <sum>
	Examples:
	| numbers  | sum    |
	|          | 0      |
	| 1        | 1      |
	| 1,2      | 3      |
	| 100, 100 | 200    | 










































#Scenario Outline: Calculator adds an arbitrary amount of numbers
#	Given I have entered <numbers> as text
#	When the calculator adds them
#	Then the result should be <sum>
#	Examples:
#	| numbers                                                     | sum |
#	| 1,1,1                                                       | 3   |
#	| 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 | 30  |
#	| 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 | 0   |
#	
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#Scenario Outline: Calculator treats both comma and newline as number separators
#	Given I have entered <numbers> as text
#	When the calculator adds them
#	Then the result should be <sum>
#	Examples:
#	| numbers  | sum    |
#	| 1\n1     | 2      |
#	| 1,1      | 2      |
#	| 1\n1,1   | 3      |
#	| 1,1\n1   | 3      |
#	
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#Scenario Outline: Calculator can support customized delimiter characters
#	Given I have entered <numbers> as text
#	When the calculator adds them
#	Then the result should be <sum>
#	Examples:
#	| numbers     | sum |
#	| //[;]\n1;1  | 2   |
#	| //[{]\n1{2  | 3   |
#	
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#Scenario Outline: Calculator does not handle negative numbers
#	Given I have entered <numbers> as text
#	When the calculator tries to add them
#	Then the result should be an error
#	And the error message should explain that <invalidnumbers> was invalid input
#	Examples: 
#	| numbers   | invalidnumbers |
#	| -1,1      | -1             |
#	| 1,-1      | -1             |
#	| -1,-2     | -1,-2          |
#	
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#Scenario Outline: Calculator can support customized delimiter strings (sets of characters)
#	Given I have entered <numbers> as text
#	When the calculator adds them
#	Then the result should be <sum>
#	Examples:
#	| numbers         | sum |
#	| //[;;;]\n1;;;1  | 2   |
#	| //[{;x]\n1{;x2  | 3   |