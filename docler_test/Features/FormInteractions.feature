@form_interactions
Feature: FormInteractions
	Testing welcome pages with form submissions

@HighPrio @REQ-UI-12
Scenario Outline: Entering name in the form
	Given I am on the "form_page"
	When I type "<name>" in the "input_field"
	And Click on the "submit_button"
	Then I should be redirected to the "hello_page"
	And A "<welcome>" text should appear

	Examples:
	| name    | welcome        |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |
