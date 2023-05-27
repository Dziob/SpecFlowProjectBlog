Feature: Site title links to home page
A short summary of the feature

@tag1
Scenario: As a User, I enter a About page and by clicking Site Title I go back to the home page.
	Given I enter to Home page
	And I go to About page
	When I click on Site Title
	Then I ecpect to go back to Home Page
