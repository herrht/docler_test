@page_appearance
Feature: PageAppearance
	Test if important page elements are visible

@HighPrio @REQ-UI-11
Scenario: Form is visible with input field and submit button
	When I am on the "Form"
	Then The "form" should be visible
	And The "input field" should be visible
	And The "submit button" should be visible

@ModeratePrio @REQ-UI-01 @REQ-UI-02
Scenario: Check page title and logo on every page
	When I am on the "<page>"
	Then The title should be "UI Testing Site"
	And The "company logo" should be visible

	Examples:
	| page  |
	| Home  |
	| Form  |
	| Error |
	| Hello |

@LowPrio @REQ-UI-04 @REQ-UI-09 @REQ-UI-10
Scenario: Check the icon and texts on the home page
	When I am on the "Home"
	Then The "home" button should turn to active status
	And The text should be visible in "h1": "Welcome to the Docler Holding QA Department"
	And The text should be visible in "p": "This site is dedicated to perform some exercises and demonstrate automated web testing."

@LowPrio @REQ-UI-06
Scenario: Check the icon on the form page
	When I am on the "Form"
	Then The "form" button should turn to active status
