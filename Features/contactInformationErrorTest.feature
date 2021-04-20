Feature: contactInformationErrorTest
	Goto Contact Page, filling invalid data and see error message

@TestCase3
Scenario: Test case 3
	Given From home page to contact page
	And Populate mandatory feilds with invalid data
	When After Finish filling feilds
	Then Error message is displayed