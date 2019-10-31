# MSO Final project: shop

## Introduction

The final project of this course consists of designing and implementing a shop application that customers can install on their computer and buy products with. 

## Overview of the shop application

The shop application should be able to handle two kinds of products: digital products and physical products. Digital products are download-only products. Physical products should be sent to the customer by mail.

After launching the application, the customer can browse through a list of products and view information about each product (title, description, price, type of product (digital or physical), and a download link (only for digital products)). 

A customer can choose to add products to their cart. They can do this by entering a quantity and click on a button to add that quantity of products to the card. A cart may contain any number of different products. After the customer has placed the products she wants in her shopping cart, she proceeds to order checkout by filling out their personal details (name, email address and in some cases, their home address consisting of street name and number, zip code, and town). Then, the customer proceeds to pay the total amount + a shipping fee if necessary. After successfully paying the order, the customer will receive an email with a confirmation. If the payment fails, the customer returns to the the cart, so they can re-initiate payment or cancel the order entirely.

Physical and digital products are handled differently after the customer has paid. For physical products, an email should be sent to the company containing the product details and quantity so they can send the product to the customer. For digital products, the customer should receive an email with a license code and a download link for the software. If an order only contains digital products, no shipping fee should be applied to the total amount.

## Limitations

Obviously, a real shop application has a lot of components that are difficult to implement in a standalone assignment, such as email notifications, a database integration, payment processing, stock management, and so on. For this particular application, let's make a few assumption to simplify things:
- There is no database, but simply a text file with product descriptions.
- The application does not actually send emails. Emails are simply printed to the console. You do need to make sure that it is possible to easily add e-mail functionality without having to completely refactor the application.
- There is no stock management, so we assume that for each product there is an infinite stock.
- When a customer pays, there is no actual payment, but you simply let the customer choose between 'success' and 'fail', with which you select whether the payment is successful. 
- When sending the email for digital products, simply generate a random license key string.

## Assignment
In this assignment, you will design and implement the system as described above. In the final step of the assignment, you will add unit tests to verify that the system works as intended.

### Part I

Perform a CVA (commonality/variation analysis) to determine the commonalities and the variations. Write this down in a table.

### Part II

Based on the analysis you performed in the previous part, write a UML class diagram that contains the classes that are needed for the shop application. Give a description of the responsibilities of each class. Also describe which design patterns you have used, and how. Compare your choices with possible alternatives and provide arguments that explain why you chose this particular solution. Explain whether there are any changes/extensions with respect to the CVA in the previous part.

### Part III

Create a prototype of the application following your design and taking into account the limitations described above. Note that it is not important for this assignment to make an application that looks nice, the main aim is to implement your design and come up with a working prototype. You may create a console application or use a GUI, but don't spend too much time on perfecting the visuals and the interaction.

### Part IV

Especially in the part of the application that deals with payment and handling orders, there are quite a few cases that the application needs to be able to handle. For instance: 
- an order should only be fulfilled if payment is successful
- shipping should not be added if the order only contains digital products
- an order should never have products with a quantity of zero

For each of the cases above, write a unit test that verifies that the application handles this case correctly. Define at least 3 more cases that the payment/order system should handle, and write unit tests for those as well.

A few notes:
- Use the assert mechanism as a part of the unit tests. It is highly recommended to use the built-in C# unit testing library.
- Separate the test code from the application code, and make sure the tests can be run as an independent program.

### Part V

Discuss how design patterns and the object-oriented design tools (such as CVA) have helped writing code that is more easily testable. Did you have to refactor your code in order to support unit testing it? Are there currently parts of your prototype application that are difficult to test? Why is that and what could be a possible remedy?

## Submission
Submit your implementation of the prototype shopping software, based on your design. Also answer the questions above, using the template in the Appendix. Consult the course planning for the deadline.

## Taal
De opdracht mag zowel in het Engels als Nederlands worden gemaakt.

# Appendix: report format

## MSO Final project

| Student name    | Student id    |
|-----------------|---------------|
| <student1_name> | <student1_id> |
| <student2_name> | <student2_id> |

### CVA
Answer Part I by providing a CVA matrix.
### UML diagram
Provide a UML diagram, and a discussion of the design as asked in part II.
### Unit tests
Answer part V here.
### Technical information
Give a short description of the actual prototype and how the code is structured, how to compile and run it and how to run the unit tests. Please provide a basic manual explaining how your application works. This is mainly intended to help the teaching assistant grade your project more efficiently.