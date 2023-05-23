Feature: Feature1

A short summary of the feature

@tag1
Scenario: As User I enter to blog and I'm contacting by contact form.
 Given I enter to 'home' page
 And I click on ”Contact" in menu
 When I fill contact form
 Then I expect to see message as „Message Sent (go back)”
