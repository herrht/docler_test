@page_appearance
Feature: PageAppearance
	Test if important page elements are visible

@HighPrio @REQ-UI-11
Scenario: Form is visible with input field and submit button
	When I am on the "/form.html"
	Then The "hello-form" should be visible
	And The "hello-input" should be visible
	And The "hello-submit" should be visible

@ModeratePrio @REQ-UI-01 @REQ-UI-02
Scenario: Check page title and logo on every page
	When I am on the "<page>"
	Then The title should be "UI Testing Site"
	And The "dh_logo" should be visible

	Examples:
	| page       |
	| /          |
	| /form.html |
	| /error     |

@ModeratePrio @REQ-UI-01 @REQ-UI-02
Scenario: Check page title and logo on submitted form page
	#Given I am on the "/form.html"
	#When I type "Tester" in the "hello-input"
	#And Click on the "hello-submit"
	#Then I should be redirected to the "hello.html"
	When I am on the "/hello.html"
	Then The title should be "UI Testing Site"
	And The "dh_logo" should be visible

@LowPrio @REQ-UI-04 @REQ-UI-09 @REQ-UI-10
Scenario: Check the icon and texts on the home page
	When I am on the "/"
	Then The "home" should turn to active status
	And The text should be visible in "h1": "Welcome to the Docler Holding QA Department"
	And The text should be visible in "p": "This site is dedicated to perform some exercises and demonstrate automated web testing."

@LowPrio @REQ-UI-06
Scenario: Check the icon on the form page
	When I am on the "/form.html"
	Then The "form" should turn to active status
