Feature: PopulateForms
	

@mytag
Scenario: As a user I want to populate the fields
	Given I navigate to the page
	And enter first name "Dimitar"
	And enter last name "Stojanovski"
	When enter email address "dimitar@mail.com"
	Then I want to select gender