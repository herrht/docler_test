﻿@page_navigation
Feature: PageNavigation
	Test nagivation between pages of the site

@HighPrio @REQ-UI-03 @REQ-UI-05 @REQ-UI-08
Scenario Outline: Navigation between pages
	Given The "navigation_bar" is visible
	When I click on the "<button>"
	Then I should get navigated to the "<page>"

	Examples: 
	| button            | page      |
	| home_button       | home_page |
	| form_button       | form_page |
	| UI_Testing_button | home_page |

@HighPrio @REQ-UI-07
Scenario: Go to error page and get error response
	Given The "navigation_bar" is visible
	When I click on the "error_button"
	Then I should get a "404 HTTP Response code"
