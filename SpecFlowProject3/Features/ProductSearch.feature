﻿Feature: ProductSearch

As a registered user 
I should be able to gain acess to the website using my username and password 
So that I can search for an item and add it to my cart

Scenario: User can search for a product

Given a pre existing user logs in using their email and password
When the user searches for an item
Then the item is displayed with the correct price

Scenario: User can add a product to the cart

Given a pre existing user logs in using their email and password
When the user searches for an item
Then the user can add the prodcut to their cart

Scenario: User can remove a product from the cart

Given a pre existing user logs in using their email and password
When the user searches for an item
And adds the item to cart 
And the user navigates to the cart
Then removes the item from cart

Scenario: User can increase the amount of products in their cart

Given a pre existing user logs in using their email and password
And has an item in their cart
When the user navigates to the cart
And increases the amount of the item 
Then a success message is displayed 

Scenario: User can decrease the amount of products in their cart

Given a pre existing user logs in using their email and password
And has an item in their cart
When the user navigates to the cart
And decreases the amount of the item 
Then a success message is displayed 

Scenario: User can search for an invalid product

Given a pre existing user logs in using their email and password
When the user searches for an invalid item
Then a message is dsiaplyed that no products match the search criteria 