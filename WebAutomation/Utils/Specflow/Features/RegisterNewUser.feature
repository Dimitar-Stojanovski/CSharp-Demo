Feature: RegisterNewUser
	

@mytag
Scenario: As a user I want to register
	Given I navigate on the page
	And I click New User Button
	And I enter First Name "Dimitar"
	And I enter Last Name "Stojanovski"
	And I enter UserName "Username1"
	And I enter Password "Password1"
	When I press register button
	Then Verify the message "Please verify reCaptcha to register!"