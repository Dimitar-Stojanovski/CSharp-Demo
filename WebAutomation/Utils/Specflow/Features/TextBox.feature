Feature: TextBox
	

@myTag
Scenario: As a user I want to populate text box page
	Given Navigate to the page
	And Populate Full Name
	And Populate Email
	And Populate Current Address
	And Populate Permanent Address
	When I click Login Button
	Then I want to verify the data