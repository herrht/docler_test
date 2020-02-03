@page_navigation
Feature: PageNavigation
	Test nagivation between pages of the site

@HighPrio @REQ-UI-03 @REQ-UI-05 @REQ-UI-08
Scenario Outline: Navigation between pages
	Given The navigation bar is visible
	When I click on the "<button>"
	Then I should get navigated to the "<page>"

	Examples: 
	| button     | page |
	| Home       | Home	|
	| Form       | Form |
	| UI Testing | Home |

@HighPrio @REQ-UI-07
Scenario: Go to error page and get error response
	Given The navigation bar is visible
	When I click on the "error"
	Then I should get an error response code
