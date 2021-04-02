# ConsoleCalculator
Console Calculator for IS421

# Background
This Console Calculator will calculate 2 values and return the calculated result based on the selected operation. However, instead of using simple methods, classes and variables, the project instead utilizes design patterns, delegates/events, lambda functions, etc. This is to ensure the Console Calculator follows OOPs principles (Abstraction, Polymorphism, Inheritance, Encapsulation), and the SOLID principles (such as applying Single-responsibility, Open-closed Principle, Liskov Subsitution Principle, Interface Segregation, and Dependency Inversion) as much as possible. Design patterns such as Strategy, Factories/Abstract Factories, Observers, are utilized in order to keep the Calculator abstract and easy to work with, in case of any potential future extensions. This article will go over the Console Calculator's major functionalities, and how SOLID and the design patterns were applied.

In order to satisfy SOLID:

* **Single-responsibility**: "A class should have one, and only one, responsibility."

* **Open-closed Principle**:  "Software should be open for extension, but closed for modification."

* **Liskov Subsitution**:  "If any module is using a Base class then the reference to that Base class can be replaced with a Derived class without affecting the        functionality of the module."

* **Interface Segregation**: "Many client-specific interfaces are better than one general-purpose interface."

* **Dependency Inversion**: "Depend on abstractions not on concrete implementations."


# Introduction

Before we go over the ins and outs and the levels of abstractions. Let us quickly take a look on how the the different Operations calculate our number inputs.
![image](https://user-images.githubusercontent.com/43587456/113422673-1e26b800-939b-11eb-89b7-59e8d3accfd8.png)

Instead of encapsulating the operations within seperate classes or methods, I used a Func delegate (that takes in 2 double inputs and returns type double) to then use lambda expressions to create the anonymous functions. With each anonymous function corresponding to the most commonly used calculator operations. These operations will be the very foundation this whole calculator project will be based on. 

![image](https://user-images.githubusercontent.com/43587456/113424054-824a7b80-939d-11eb-8ab5-5852a217e37c.png)

There is another class of operations in the event that multiple numbers are inputted.


The next 5 sections will discuss how I applied 5 different design patterns to the most major parts of the project in order to satisfy SOLID.

# The Abstract Factory

This design pattern was applied to satisfy the Interface Segregation Principle and the Dependency Inversion Principle.
Within the Interface folder in MyCalculator, the IAbstractCalcFactory file. This code creates multiple seperate classes that interface with the concrete implementations.   

![image](https://user-images.githubusercontent.com/43587456/113425212-78c21300-939f-11eb-945a-a57d4d607592.png)

The concrete factories that the Abstract Factory interface with:

![image](https://user-images.githubusercontent.com/43587456/113425591-26cdbd00-93a0-11eb-8688-5cca4a0b1d5d.png)

The bottom method acts as a sort of work-around hack to solve the issue of not being able to call static methods from non-static functions.
Which is then called here to _Create_ the calculation object to calculate: 

![image](https://user-images.githubusercontent.com/43587456/113426031-dd31a200-93a0-11eb-95c5-5b47ef449a54.png)
![image](https://user-images.githubusercontent.com/43587456/113426060-e753a080-93a0-11eb-9a95-6206c2a68e07.png)


# Builder Pattern

This design was applied to satisfy Single-Responsibility of classes, Liskov Substitution and Dependency Inversion as much as possible.
The implementation is found here: 

![image](https://user-images.githubusercontent.com/43587456/113426466-81b3e400-93a1-11eb-8da1-c000fbb0d5f6.png)

The Builder class interfaces with the ICalculator Class:

![image](https://user-images.githubusercontent.com/43587456/113427069-69909480-93a2-11eb-9ccc-c92b29189047.png)

The Builder pattern allows me to configure the resulting object (whether List or non-List of inputted values) Thus I can construct different objects using the same building process.


# Strategy Pattern

As we move on from the layers of calculator abstraction, the actual User Interface, the Console, also holds several design pattern in order to better communicate data from user input to the main algorithms. 
One way to act on user input is to use conditionals such as switch statements. But I wished to not ask the program what to do, but simply tell what it needs to do on a particular input. Thus led me to using the strategy design. 

This satisfies the Open-Closed Principle, Interface Segregation and Dependency Inversion.

![image](https://user-images.githubusercontent.com/43587456/113427994-030c7600-93a4-11eb-8a8c-170a3c6956e0.png)

This strategy is essentially a list of operations the user can directly choose. Which will then return the appropriate operation to perform. 

The same methodology is applied to the list of options the user can choose when using the Console Calculator:

![image](https://user-images.githubusercontent.com/43587456/113428309-92b22480-93a4-11eb-88b5-30bebe9a62cd.png)

But how will the user interface with the Operation/Option Strategy?

# Factory

For both the Operations and Options strategy, I set up a Dictionary and a mini-factory to create the return object needed.

![image](https://user-images.githubusercontent.com/43587456/113428564-03f1d780-93a5-11eb-81ba-0bb6e858f144.png)

Based on the User's string input, it will match the string input and the predetermined Operation object by interfacting with the OperationStrategy interface. 
The same is applied to the Options Strategy:

![image](https://user-images.githubusercontent.com/43587456/113428862-9003ff00-93a5-11eb-9edd-f28f43550055.png)


# Observers
Along with events, I implemented observers to detect when the calculation is performed. And to inform the user of the calculation's completion and their input.

![image](https://user-images.githubusercontent.com/43587456/113429044-df4a2f80-93a5-11eb-87cb-9b469cdc3cbe.png)

![image](https://user-images.githubusercontent.com/43587456/113429059-e6713d80-93a5-11eb-8a8d-49e548d1dea4.png)

How you'd attach, detach and notify observers are implemented within the ConsoleEventManager class. 

![image](https://user-images.githubusercontent.com/43587456/113429274-410a9980-93a6-11eb-812e-0f3de85dadc0.png)

# Final Words

All in all, as difficult this project was to learn, it was an enjoyable challenge. This project alone taught me more Object Oriented principles and designs in 2 months, than I have in my past 2 Computer Science classes. It taught me a LOT of the fundamentals of proper software architecture and engineering. Especially if I'm not creating quick scripts, I am for sure going to continue to apply these methodologies and OOP ideas into my future projects. 





 
# Articles and Sources that Helped Me and My Project
1. https://stackoverflow.com/questions/48377525/replace-conditional-with-polymorphism
2. https://refactoring.guru/replace-conditional-with-polymorphism
3. https://refactoring.guru/design-patterns/abstract-factory/csharp/example
4. https://refactoring.guru/design-patterns/strategy/csharp/example
5. https://www.c-sharpcorner.com/article/observer-pattern-implementation-in-net-framework/
6. https://www.c-sharpcorner.com/UploadFile/1c8574/events-in-C-Sharp/
7. https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-subscribe-to-and-unsubscribe-from-events
8. https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
