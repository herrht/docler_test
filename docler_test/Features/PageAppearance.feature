@page_appearance
Feature: PageAppearance
	Test is important page elements are visible

@HighPrio @REQ-UI-11
Scenario: Form is visible with input field and submit button
	When I am on the "form_page"
	Then The "form" should be visible
	And The "input_field" should be visible
	And The "submit_button" should be visible

@ModeratePrio @REQ-UI-01 @REQ-UI-02
Scenario: Check page title and logo on every page
	When I am on the "<page>"
	Then The "title" should be "UI Testing Site"
	And The "company_logo" should be visible

	Examples:
	| page  |
	| home  |
	| form  |
	| error |

@ModeratePrio @REQ-UI-01 @REQ-UI-02
Scenario: Check page title and logo on submitted form page
	Given I am on the "form_page"
	When I type "Tester" in the "input_field"
	And Click on the "submit_button"
	Then I should be redirected to the "hello_page"
	And The "title" should be "UI Testing Site"
	And The "company_logo" should be visible

@LowPrio @REQ-UI-04 @REQ-UI-09 @REQ-UI-10
Scenario: Check the icon and texts on the home page
	When I am on the "home_page"
	Then The "home_button" should turn to active status
	And The text should be visible in "h1_tag": "Welcome to the Docler Holding QA Department"
	And The text should be visible in "p_tag": "This site is dedicated to perform some exercises and demonstrate automated web testing."

@LowPrio @REQ-UI-06
Scenario: Check the icon on the form page
	When I am on the "form_page"
	Then The "form_button" should turn to active status
