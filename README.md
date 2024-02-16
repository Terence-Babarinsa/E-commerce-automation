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
In this testing strategy, I categorized test scenarios based on their equivalence classes, ensuring comprehensive coverage while maintaining efficiency. By identifying input data that fall into the same equivalence classes, I aimed to streamline the testing process without delving into boundary conditions. This approach allows for a systematic examination of different input sets, promoting thorough testing across various scenarios. Embracing a Behavior-Driven Development (BDD) perspective, I focused on clarity and coherence in articulating test scenarios, aligning them with the corresponding equivalence classes for effective test automation. Leveraging SpecFlow, a BDD framework for .NET, I seamlessly integrated these categorized test scenarios, ensuring that each class receives adequate testing attention. This approach optimizes resource utilization by targeting representative inputs within each equivalence class, thereby enhancing the overall efficiency and effectiveness of the testing process.
By emphasizing equivalence partitioning over boundary value analysis, the testing strategy prioritizes the systematic exploration of input data variations while minimizing the complexity associated with boundary conditions. This ensures a robust testing framework that aligns with the principles of Behavior-Driven Development, fostering collaboration and clarity throughout the testing lifecycle.

## How to use the framework

### Features
- BDD test scripts that are written in Gherkin syntax
### StepDefinitions
- StepDefinitions generated from feature files
- Each method correlates with a statement on each test script line
### POM
- Page Object Models that contain locators for IWebelements and the interactions with the elements
### Drivers
- Contains the driver class that defines the driver and controls its properties
### CommonSetup
- Consolidates my BefreoScenario and AfterScenario for all StepDefinitions into a single file
### GetMethods
- Class to assign the relevant locators for a webelement
### Properties
- Enumerator with locators for Iwebelements that are assigned by the GetMethods Class
### Packages
- NUnit
- Specflow
- Selenium
