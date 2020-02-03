@form_interactions
Feature: FormInteractions
	Testing welcome pages with form submissions

@HighPrio @REQ-UI-12
Scenario Outline: Entering name in the form
	Given I am on the form page
	When I type "<name>" in the input field
	And Click on the submit button
	Then I should be redirected to the Hello page
	And A "<welcome>" text should appear

	Examples:
	| name    | welcome        |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |
