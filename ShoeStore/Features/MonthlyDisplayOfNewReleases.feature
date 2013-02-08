Feature: Monthly display of new releases
	In order to view upcoming shoes being released every month
	As a user of the Shoe Store
	I want to be able to visit a link for each month and see the shoes being released.

Scenario Outline: Shoe information for each month
	Given I am at the Shoe Store site
	When I choose <month>
	Then I should see a small Blurb for each shoe
	And I should see an image for each shoe
	And I should see a suggested retail price for each shoe
	Examples:
		| month     |
		| January   |
		| February  |
		| March     |
		| April     |
		| May       |
		| June      |
		| July      |
		| August    |
		| September |
		| October   |
		| November  |
		| December  |

#Notes:
# Should each month have at least one shoe displayed?