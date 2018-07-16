Feature: Login Page
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: 01 Login functionality with Valid credentials as Owner of property.
	Given I have opened the Login page
	And I have entered valid <User name>, valid <Password>
	When I click on Login button
	Then the Dashboard page should open 

	Examples: 
	| User name                      | Password |
	| vincent.nguyen@mvpstudio.co.nz | ntmv2682 | 
