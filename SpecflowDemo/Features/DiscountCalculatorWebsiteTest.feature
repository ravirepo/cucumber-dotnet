Feature: Verify Discount Website

@web
Scenario: Verify Discount Website
	Given I am a customer who is looking for a discount on the website
	And My address is in "NJ" on the website
	When I view my discount on the website
	Then I expect a "10" percent discount on the website

@web
Scenario Outline: Validate Discount rules
	Given I am a customer who is looking for a discount on the website
	And My address is in "<State>" on the website
	And My Profession is "<Profession>" on the website
	When I view my discount on the website
	Then I expect a "<Expected Discount>" percent discount on the website

	Scenarios: 
	| Scenario        | State | Scenior Citizen | Profession | Expected Discount |
	| PA Resident     | PA    | No              | NA         | 10                |
	| Developer       | CA    | No              | Developer  | 10                |
