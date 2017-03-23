# Object-Oriented Basics
1. Abstraction
2. Encapsulation
3. Polymorphism
4. Inheritance

# Object-Oriented Principles
1. Encapsulates what **varies**
2. Favor **composition** over **inheritance**
3. Program to **interfaces**, not to **implementations**
4. Strive for **loosely coupled** designs between objects that interact

# Design Patterns

## Strategy Pattern
The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Observer Pattern
The observer pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependent are notified and updated automatically.
> Note: better to let `observers` to "pull" data from `observable`
