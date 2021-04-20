Feature: ContactInformationErrorGoneTest
	Go to Contact Page, click submit button , error message is displayed, then filling the fields, error message is gone

@TestCase1
Scenario: Test Case 1
	Given Go to contact page and click the submit button
	And Error message is displayed
	When Populate mandatory fields
	Then Validate error message is gone