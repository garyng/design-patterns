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
7. Talk only to your **immediate friends**. (_Principle of Least Knowledge_ / _Law of Demeter_)
> Any method in an object should only invoke methods that belong to
> 1. The object itself
> 2. Objects passed in as a parameter to the methods
> 3. Any object the method creates of instantiate
> 4. Any components of the object
8. Don't call us, we'll call you (_Hollywood Principle_ / _Inversion Of Control_ / _Dependency Injection_)
9. A class should have only **one reason** to change (_Single Responsibility Principle_)

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

## Singleton Pattern
The singleton pattern ensures a class has only one instance, and provides a global point of access to it.

## Command Pattern
The command pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

## Adapter Pattern
The adapter pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

## Façade Pattern
The façade pattern provides a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.

## Template Method Pattern
The template method defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

## Iterator Pattern
The iterator pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

## Composite Pattern
The composite pattern allows you to compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

## State Pattern
The state pattern allows an object to alter its behaviour when its internal state changes. The object will appear to change its class.

## Proxy Pattern
The proxy pattern provides an surrogate or placeholder for another object to control access to it.
