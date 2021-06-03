Feature: SignIn
	

@signIn
Scenario: sign in with valid credentials
	Given user is on the website
	And user click accept cookies
	And user clicks sign in
	When user enters valid credentials "testingtest825@mail.com","Fulham11"
	Then user should be signed in