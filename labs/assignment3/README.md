# MSO Lab Assignment III

## Introduction
In this lab exercise, you will revisit your proposed design for the ticket machine from the previous lab exercise and implement a prototype. The aim of this lab is to reflect on your original design, and learn from any mistakes you may have made.

## Assignment

In the previous lab exercise, you designed the core functionality of a trainticket machine. Start by extracting the file `lab3.zip` located in this folder. This zip file contains a simple C# Windows Form Application, implementing the core functionality of the train ticket system described in the previous exercise. The main computations happen in the `UI.cs` file – almost all the changes you will need to implement should be restricted to this file. You will, of course, also need to add new classes that you designed yourself.

### Part 1

Read through the current implementation of the ticket system. Do not worry too much about the the GUI or the existing classes for handling coin or PIN payments – instead focus on the description of tickets and their price calculation.
- Describe the relative merits of the current solution. What works well? What could be improved? We are only interested in the design of the train tickets (as in your previous exercise), you do not need to discuss the (fake) coin machine, card reader,
or pricing table classes.
- What kind of changes or new requirements would be easy to add? What new features would be difficult to add?
- Which bad code smells can you identify? Evaluate the cohesion and coupling of the current solution.

### Part 2

This question is divided into several parts:

- Implement the design you proposed as part of the previous exercise. By doing so, you will probably identify shortcomings or imperfections in your original design.
- Give a UML class diagram for the solution that you ended up implementing. Be as complete and accurate as possible.
- How does the implemented design differ from your original design? What errors can you spot in your original design? How does the code you ended up implementing differ from the design you proposed previously? Be honest: we will not deduct marks for mistakes you made in the previous exercise. Instead, we are
looking for a comprehensive assessment of the shortcomings in your previous design, and how you revised it during the implementation. The more thorough the comparison between your original design and the design you implemented, the better we will grade your work.
- What have you learned about your original design?

## Submission
Submit your final implementation of the train ticket software, based on your origal design and adapted as needed. Also answer the questions above, using the template in the Appendix. Consult the course planning for the deadline.

## Taal
De opdracht mag zowel in het Engels als Nederlands worden gemaakt.

## Appendix: report format

### MSO Lab Exercise III: Implementing the NS ticket machine

| Student name    | Student id    |
|-----------------|---------------|
| <student1_name> | <student1_id> |
| <student2_name> | <student2_id> |

#### Initial assessment
Answer Question 1, giving an initial assessment of the code you are given.
#### Implementing our design
Answer Question 2, providing both the original and revised UML diagrams corresponding to your original design and the design you ended up implementing. Describe the changes you needed to make and what you learned about your original design.