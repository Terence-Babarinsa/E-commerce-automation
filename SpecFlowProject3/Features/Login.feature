Feature: Pre existing user login
As a registered user
I should be able to gain access to the website using my username and password
So that I can access my acccount information

@Login
Scenario: Valid Login
	Given the valid url
	When I enter the correct username and password
	And Click Login
	Then I can view my accout information

Scenario: Invalid Loign with invalid email
	Given the valid url
	When I enter the invalid email and valid password
	And Click Login
	Then I can not view my account information

Scenario: Invalid Loign with invalid password
	Given the valid url
	When I enter the invalid password and valid email
	And Click Login
	Then I can not view my account information

Scenario: Forgotten password with valid email
	Given the valid url
	When I navigate to the forgotten password page
	And enter the correct email address
	And click continue
	Then I am alerted that a confirmation link has been sent

Scenario: Forgotten password with invalid email
	Given the valid url
	When I navigate to the forgotten password page
	And enter an incorrect email address
	And click continue
	Then I am alerted the email wasnt found in the records