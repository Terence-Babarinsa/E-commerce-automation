# E-commerce-automation
This repository documents the design and implementation of an automation framework to test the login and product search features on an e-commerce website

## Project overview
This project looks to test the following features: 

#### Login:
 - Pre-existing users can gain access to the platform using email and password.
 - Upon successful entry, they should be able to view their account information.
#### Product Search:
 - A pre-existing user can gain access to the platform using email and password.
 - Search for an HTC Touch HD, confirm the price, add it to the Cart, and verify the item is in the Cart.

## Testing approach:
In my testing strategy, I prioritized the seamless transition from test scripts to automation code. Embracing a Behavior-Driven Development (BDD) perspective, I aimed for clarity and coherence. BDD, characterized by its Gherkin syntax, fosters a shared understanding among stakeholders. This linguistic simplicity not only enhances communication but also facilitates the translation of requirements into automated tests. Leveraging SpecFlow, a BDD framework for .NET, I ensured smooth integration between the articulated test scenarios and the automation infrastructure. SpecFlow acts as a bridge, enabling the transformation of plain-text specifications into executable tests. By adopting this approach, I aimed to minimize ambiguities and streamline the testing process. The BDD methodology not only promotes collaboration but also emphasizes the alignment of business objectives with technical implementation. This alignment is crucial for delivering high-quality software that meets user expectations. By marrying the clarity of BDD with the efficiency of automation frameworks like SpecFlow, I strived to enhance the effectiveness and reliability of the testing process, ultimately contributing to the overall success of the project.

## How to use the framework

### Features
- BDD test scripts that are written in Gherkin syntax
### StepDefinitions
- StepDefinitions that generated from feature files
- Each method correlates with a statement on each test script line
### POM
- Page Object Models that contain locators for IWebelements and the interactions with the elements
### GetMethods
- Class to assigns the relevant locators for a webelement
### Properties
- Enumerator that has specified locators that are assigned by the GetMethods Class
