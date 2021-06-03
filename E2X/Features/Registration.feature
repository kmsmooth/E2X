Feature: Registration
	

@Resgistration
Scenario: register to be a user
	Given user is on the website
	And user click accept cookies
	And user clicks register
	And user fill in their details <Email>,<Password>,<Cpassword>,<FirstName>,<LastName>,<Address>,<City>,<Postcode>,<PhoneNumber>,
	When user clicks on create account
	Then user should see account has been created
	Examples: 
	|Email                  |Password|Cpassword|FirstName|LastName|Address      |City  |Postcode|PhoneNumber|
	|testingtest830@mail.com|Fulham11|Fulham11|Paul      |Baines  |825 Long Lane|London|SW1 2PE |07901008311|
	

