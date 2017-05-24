Feature: Test


Scenario Outline: Testing Various Calculations
	Given calculator application is open
	When I enter two "<First Number>" "<Second Number>" number and do a matamatical fucntion to them "<Function>"
	Then the result should be this "<Result>"
	Examples:
	| First Number | Second Number | Function | Result |
	| 2            | 2             | Add      | 4      |
	| 5            | 3             | Subtract | 2      |
	
	
	
	