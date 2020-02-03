@form_interactions
Feature: FormInteractions
	Testing welcome pages with form submissions

@HighPrio @REQ-UI-12
Scenario Outline: Entering name in the form
	Given I am on the "/form.html"
	When I type "<name>" in the "hello-input"
	And Click on the "hello-submit"
	Then I should be redirected to the "/hello.html"
	And A "<welcome>" text should appear

	Examples:
	| name    | welcome        |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |
