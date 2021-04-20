Feature: SubmissionSuccessfulTest
	Go to Contact Page and filling proper contents to fields then submit it successfully

@TestCase2
Scenario: Test Case 2
	Given Go to contact page
	And Filling mandatory fields
	When Click Submit
	Then the information message should be displayed