Feature: Login

Check if Login functionality works

@mytag
Scenario: Login user as Administrator
	Given I navigate to application
	And I click login
	And I enter username and password
	| UserName | Password |
	| admin    | admin    |
	#Then I should see user logged in to the application
	
