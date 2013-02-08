Feature: Submit Email For Reminder
	In order to be reminded of upcoming shoe releases
	As a user of the Shoe Store
	I want to be able to submit my email address

Scenario Outline: Submit email address
	Given I am at the Shoe Store site
	When I submit <email>
	Then I should see a <notice>
	Examples: 
	| email                   | notice                                                    |
	| umair.chagani@gmail.com | Thanks! We will notify you of our new shoes at this email |

#Notes:
# What message should the user see if they submit an invalid email address?
