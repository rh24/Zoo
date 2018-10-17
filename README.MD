# Zoo

This is a .NET Core Console application that serves to mimic a zoo. When the user fires up the application, seven different types of concrete animals will display their traits in the terminal. This project serves as a way to practice Object Oriented Programming principles, namely, Inheritance, Polymorphism, Encapsulation, and Abstraction.

Inheritance means that classes can have access to the members of the base class from which it inherits. This extends to methods, properties, events, and fields, etc. as long as their access modifier is not private.
* Mammal inherits from Vertebrata.

Polymorphism is the concept of derivative class members changing shape according to the class's needs.
* Mammal overrides the abstract Endoskeleton and Brain properties from abstract class Vertebrata.

Encapsulation is the idea of enclosing everything into a black box, in which outsiders do not know what goes on inside there, but they know how to use the box.
* Within the Cat class, there is a method called ShouldTouristApproach. We don't know how the outputted string is being determined, we only know that a message is printed out and that we can call this method.

Abstraction is the concept of turning complex concrete entities into idealogical representations of what they are and what they can do. Asbstraction hides away the details necessary to execute actions.
* I've made an abstraction of a Cat into a Cat class. It's a representation of a Cat with properties and behaviors that a real world cat might have. Two of these behaviors are Sleeps() and Plays().

Several classes implement up to two different interfaces. Interfaces allow developers to interact with classes for what they do and not how they do it. In other words, an interface dictates that developers implement specific members within the classes that will use the given interface. Classes can implement more than one interface. 
  
Interfaces are contracts that classes must fulfill. They outline what the class members should be. One of the benefits of interfaces is that they allow for runtime polymorphism. Traditionally, polymorphism in inheritance allows base classes to declare virtual members that allow for derived classes to change the 'shape' or behavior of the virtual members. This is done via *override*. Multiple inheritance is not possible in C#. However, classes can implement more than one interface. When a base class implements an interface and a derived class iherits the implementation, the polymorphic 'shape change' can take place at runtime. Overloading a method is an example of compile time polymorphism, while overriding methods via virtual methods and inheriting interface implementations, then "overriding" them with a *new* keyword, are examples of runtime polymorphism. In all of these instances, an object displays a change of shape where a declared type in the object's base class is no longer identical to the type in its class. This is the essence of polymorphism.

In this project, the two inerfaces are *IEdible* and *IApproachable*. I chose these two interfaces to implement in the abstract classes Mammal and Reptile. I implement them here because I want all concrete classes derived from Mammal and Reptile by the transitive property to implement the properties and members within my two interfaces. It didn't make sense to implement the interfaces in the concrete classes themselves. This results in a lot of code reptition. Instead, I re-assign the properties in the derivative classes when necessary. They declare the properties and methods that classes that implement them must have. For example, *Mammal* implements *IEdible*. This means that the Mammal class must have properties that describe its DeliciousRating, FattyMeat, and whether it is Diseased.

The *Reptile* class implements *IApproachable*. This means that it must have the poperties ReceivedShots, WillBite, MightCharge, and LikesAttention. It also means that the *Reptile* class must implement a method called ShouldTouristApproach, which will return a string message in the console depending on the properties of the Reptile object. 

## Class Diagram

![diagram](https://github.com/rh24/Zoo/blob/RebeccaHong-Lab05/assets/CompletedDiagram.png)

## Sample View

![console-output](https://github.com/rh24/Zoo/blob/RebeccaHong-Lab05/assets/zoo_output.png)

## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/rh24/Zoo. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the Contributor Covenant code of conduct.

## License

This project is licensed under the MIT license.
