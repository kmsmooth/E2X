Feature: CheckOut
	

@guest
Scenario: buy a product
	Given user is on the website
    And user search for a product
    And user adds that product to the cart
    When user completes the checkout process.
    Then user should get a order number
    