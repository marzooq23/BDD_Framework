Feature: Login
	Login to EA Demo Application

@EALogin
Scenario: Perform Login in EA Application Site
	#steps
	Given I launch the application																							
	And I click the login link
	And I enter the	following details
		| UserName | Password |
		| admin    | password |
	And I click login button	
	Then I should see Employee details link
	Given I Close the appliation