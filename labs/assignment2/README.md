# MSO Lab Assignment II

## Introduction
In this assignment you will work in pairs to practice designing software. Start by reading the case study below. There are several parts that you will need to answer. Please write your report using the template included in Appendix F of this assignment.

## Case study
In this assignment, you will start design a (fragment of a) ticket machines for the Nederlandse Spoorwegen. For the sake of simplicity, we will ignore many of the issues surrounding the real ticket machines – such as the OV chipcard or various different kinds of railcards (such as trajectkaarten or jaarkaarten). Instead, we limit ourself to ticket vending machines where customers may purchase paper tickets for journeys within the Netherlands. Not too long ago, it was only possible to buy tickets in person at a ticket desk. In this case study, we will consider the initial design for a first ticket vending machine.

A colleague has had several discussions with various stakeholders. You have been provided with the transcripts of these interviews (see appendix A). Read through these transcripts carefully and then complete the assignment parts below.

## Assignment

### Part 1

Write a fully-dressed description of the ticket purchasing use case. What exceptional scenarios could occur? Be sure to adhere to Larman’s guidelines for fully-dressed use cases in Chapter 6.

### Part 2

Use cases are a great way to document the functional requirements of the system. What other (non-functional) requirements can you come up with? Give a supplementary specification for the ticket machine. Use the example from section 7.2 of (the Second Edition of) Larman’s book as a template. *(Note: this is Section 7.4 in the more recent Third Edition).*

### Part 3

Based on the information given in these interviews, there may still be requirements that are unclear. What issues would you like to clarify in future discussions with these stakeholders? Explicitly state any assumptions that you make about the requirements of the proposed system.

### Part 4

Based on these interviews, scenarios and use cases, draw a domain model. Be as explicit as possible about how the entities in your model are related.

### Part 5

Use this domain model and the GRASP patterns to assign responsibilities associated with a ticket sale.

### Part 6

Design the software for the vending machine by giving a UML class diagram. You do not need to worry about the graphical user interface at this point. Instead fo- cus on identifying the classes and their relations relevant to the price calculation and printing of tickets. For each class, specify:
- the attributes associated with the class;
- the methods the class supports;
- give a brief explanation of the abstract responsibilities assigned to every class;
- also briefly describe what the methods and attributes of every class should do.

Based on this UML class diagram, it should be clear how the system you have designed will function, even if you have not implemented it yet. Be as precise as possible about the types of the various methods and attributes.

### Part 7
Explain the different kinds of variation that you have encountered in this domain. How does your design handle this variation?

### Part 8

Explicitly identify any design patterns that you have used. For each such pattern, explicitly state:
- the problem it addresses;
- how the design pattern has been applied. Be specific about the classes in your design that are associated with the design pattern.
- which alternatives did you consider?

### Part 9

Evaluate your design. Explain how it is capable of handling changing requirements. Identify at least three likely future changes to the specification. How will your design handle such changes? What kind of requirement changes would be difficult to incorporate?

## Submission
Submit a single .pdf document via Blackboard, using the template in Appendix F. Consult the course planning for the deadline.

## Taal
De opdracht mag zowel in het Engels als Nederlands worden gemaakt.