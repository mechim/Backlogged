# LAB 1
## Echim Mihail FAF 211
## SOLID Principles

## 1. Single-Responsibility 
My classes are all tasked with as little as possible. I have a Game class that is only houses the information for individual games and nothing else. The functionality of adding a game is handled in the GameManager class. The GameLibrary class only exist to provide a list for housin all the individual games, the funtionality of printing them on the screen is handled, once again in the GameManager class. The same goes for Reviews. The functionality of navigating through the program is handled in the MainMenu class. Serialization and Deserialization is handled with the SaveLoad class.

## 2. Open-closed
My classes are all open for extension. None of them need to be modified in any way. If I will ever ned to add functionality to any of my classes, I can just extend any of the classes and add the functionality in the child classes.

## 3. Liskov Substitution
I don't have any inheritance in my project, so this in not applicable

## 4. Interface Segregation
`A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.`
Since my program does not have any intefaces or abstract classes, no client is forced to implement anything it doesn't use

## 5. Dependency Inversion 
`Entities must depend on abstractions, not on concretions. It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.`
None of my classes depend on concretes
