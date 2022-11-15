Feature: Enumeration handling plug-in

# The use of the When/Then statements here are meant to demonstrate the new EnumStepArgumentTypeConverter plugin 
# is not interfering with existing built-in type converters for non-Enum types.

Scenario: Two base enum values
	Given the first color is Red
	And the second color is Blue
	When the two numbers are added 1 3
	Then the result should be 4


Scenario: Two descriptive enum values
	Given the first color is Magenta
	And the second color is Navy
	When the two numbers are added 2 4
	Then the result should be 6

Scenario: Using a regular enum continues to work as it should
	Given a regular enum value of Big

Scenario: Using a non-matching value should fail
	Given the first color is Green

Scenario Outline: Should be able to use descriptive enum values in tables
	Given the first color is <color>

	Examples: 
	| color   |
	| Red     |
	| Blue    |
	| Magenta |
	| Navy    |

Scenario: Demonstrate that quote text input also works
	Given a color as
	"""
	Magenta
	"""
