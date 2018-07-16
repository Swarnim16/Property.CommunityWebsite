Feature: MyPropertyTest
	As a Property Owner I want to 
	check all features of MyProperty Page.

@mytag
Scenario: 02 MyPropertyTest
	Given I have Login successfully using Property Owner Credentials
	And I have redirected to the Dashboard page
	When I click on Owner and then Properties menu
	Then I should have redirected to the MyProperties page
