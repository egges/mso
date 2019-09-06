# MSO Lab Assignment II

## Introduction
In this assignment you will work in pairs to practice designing software. Start by reading the case study below. There are several parts that you will need to answer. Please write your report using the template included in Appendix E of this assignment.

## Case study
In this assignment, you will start design a (fragment of a) ticket machines for the Nederlandse Spoorwegen. For the sake of simplicity, we will ignore many of the issues surrounding the real ticket machines – such as the OV chipcard or various different kinds of railcards (such as trajectkaarten or jaarkaarten). Instead, we limit ourself to ticket vending machines where customers may purchase paper tickets for journeys within the Netherlands. Not too long ago, it was only possible to buy tickets in person at a ticket desk. In this case study, we will consider the initial design for a first ticket vending machine.

A colleague has had several discussions with various stakeholders. You have been provided with the transcripts of these interviews. Read through these transcripts carefully and then complete the assignment parts that follow.

## Transcript: A ticket vendor
This is the transcript of an interview conducted with Rob Engelhart, an NS employee working at Utrecht CS.
* *So Rob, tell me about yourself.*
* My name is Rob Engelhart. I’m married and have two children. I’ve been working at the NS for the last twelve years. At first, I was based in Leeuwarden, but I moved to Utrecht five years ago.
* *And what do you do specifically?*
* I work behind the NS ticket desks, selling tickets and answering the customers questions.
* *How do you do that?*
* Well, a customer comes up to my desk and tells me where they want to go. I enter this information into the terminal at my desk. This computes the price of the ticket. Once the customer has paid this amount, I print the ticket and give it to them. If they want, I can also provide advice about the next train, or which route to take exactly.
* *What kind of tickets do you sell?*
* Oh, we sell tickets to anywhere in the Netherlands.
* *You don’t sell international tickets?*
* For international tickets, we have a separate service desk. I don’t know anything about that.
* *How is the price of a ticket computed?*
* I don’t know really. I enter the destination into my terminal, and it tells me the answer.
* *How do people pay for their ticket?*
* I don’t understand the question...
* *Well, do you accept cash?*
* Of course we accept cash!
* *What about debit cards? Credit cards?*
* Well, we accept all Dutch debit cards. We can also take any credit card, but we do charge an additional 0.50 euro for credit card payments.
* *So, what information do you enter to compute the price of a ticket?*
* I just enter the destination and the number of tickets that need to be sold.
* *And that’s all the information you need?*
* Yes.
* *What about travelling first-class?*
* Oh, if a customer wants to travel first-class, I can enter that information too.
* *Is there any other variation in the kind of tickets that you sell?*
* Sure. We sell all kinds of tickets: return tickets, single tickets, discounted tickets...
* *Wait a minute. So, when is a ticket discounted?*
* If a customer has a railcard, they get either a 20% or a 40% discount on their ticket.
* *And what does that depend on?*
* Well, on the rail card of course. Some customers have a more expensive railcard that gives them bigger discounts. But these discounts are only valid when travelling in the weekend or outside the morning rush hour.
* *And this discount is exactly 20% or 40%?*
* I guess...
* *And how is it rounded off?*
* I don’t understand the question.
* *Well, if a ticket costs 9,05 euro and I buy it with discount, it would cost 5,43 euro – but that seems a funny amount. I usually see prices advertised that are nice round numbers.*
* I really don’t know how the price is calculated. I just enter the information.
* *So in summary, customers can buy train tickets at your desk. These train tickets are only for trains travelling within the Netherlands...*
* (interrupts) Well, the train could be an international train, but then you would need an additional ticket.
* *An additional ticket?*
* Yes. Take the Thalys for instance. It runs between Amsterdam and Paris. A traveller could get on the train in Amsterdam, and leave in Utrecht. He would just need a ticket from Utrecht to Amsterdam, but he’d need to pay an additional 2 euro supplementary charge.
* *And why didn’t you mention it earlier?*
* Well you never asked me about it!
* *So, once again. Customers can buy tickets at your desk. They can pay for these tickets in a number of different ways. You sell tickets from Utrecht to anywhere in the Netherlands...*
* (interrupting) Not only from Utrecht! We can sell tickets starting from any train station in the Netherlands, except for Utrecht Maliebaan. But that’s because the station there is only for the museum and doesn’t serve any real purpose.
* *Right. So usually customers want tickets departing from Utrecht, but they can also buy a ticket departing from a different train station.*
* Exactly.
* *And once a customer buys a ticket, you print their ticket, and they get on the next train. *
* Well, it doesn’t need to be the next train. A ticket is valid for an entire day.
* *So a ticket is not associated with any particular train, but is valid for the whole day on which it was purchased.*
* Well, not all tickets work that way. Sometimes a customer will ask for a ticket without a date on it. This costs the same, but they need to validate the ticket themself before getting on the train. There are separate machines for validating your ticket - there’s one on every station.
* *And what about return tickets?*
* Return tickets have to be used on the day that they are sold. They are valid for a one return trip from the station of departure to the station of your destination and back.
* *And how is the price of a return ticket calculated?*
* I don’t know exactly. They are a bit cheaper than buying two singles. My computer just tells me the price once I input the required information.
* *Can the sale go wrong at any point?*
* Well sometimes a credit card is declined. I’ve also had a few people who didn’t have enough cash to pay for their ticket. It was pretty embarrassing, I guess.
* *Thanks for all your answers so far. I’d like to speak to someone responsible for the computer systems that you guys use.*
* I’m sure someone can help you with that.
