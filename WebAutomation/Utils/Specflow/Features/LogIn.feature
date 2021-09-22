Feature: LogIn
	Simple calculator for adding two numbers

@run
Scenario:Populate Log in Form
	Given enter username "Dimitar"
	And enter password "Password1"
	When I click LoginButton
	Then A message "Invalid username or password!" should be displayed