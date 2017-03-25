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
5. Classes should be **open for extension**, but **closed for modification** (_Open-Closed Principle_)
6. Depend upon **abstractions**. Do not depend upon **abstract classes** (_Dependency Inversion Principle_)

# Design Patterns

## Strategy Pattern
The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Observer Pattern
The observer pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependent are notified and updated automatically.
> Note: better to let `observers` to "pull" data from `observable`

## Decorator Pattern
The decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to sub-classing for extending functionality.

## Factory Pattern
### Simple Factory
> Not actually a pattern, but is commonly used

### Factory Method Pattern
The factory method pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclasses.

### Abstract Factory Pattern
The abstract factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
