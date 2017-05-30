Feature: Calculations

Scenario Outline: Calculation Test
	Given the application is open
	When I enter the following
	| First Number   | Second Number   | Function   |
	| <First Number> | <Second Number> | <Function> |
	Then I should see this "<Result>"

	Examples:
	| First Number | Second Number | Function | Result |
	| 2            | 2             | Add      | 4      |
	| 5            | 3             | Subtract | 2      |
	| 8            | 2             | Subtract | 6      |
	| 5            | 1             | Subtract | 4      |
	
	

