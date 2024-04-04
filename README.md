# Design Patterns
## Factory method
**Also known as** : Virtual Constructor

# **📜Intent**

**Factory Method** is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

![image](https://github.com/Hamroliyev/DESIGNPATTERNS/assets/90793925/51ac4e48-e24a-4178-8c91-943bbc127c94)

**☹Problem**

Imagine that you’re creating a logistics management application. The first version of your app can only handle transportation by trucks, so the bulk of your code lives inside the Truck class.

After a while, your app becomes pretty popular. Each day you receive dozens of requests from sea transportation companies to incorporate sea logistics into the app.

![image](https://github.com/Hamroliyev/DESIGNPATTERNS/assets/90793925/6c45d315-36e7-4e53-8ce1-15ee69133759)

_Adding a new class to the program isn’t that simple if the rest of the code is already coupled to existing classes._

Great news, right? But how about the code? At present, most of your code is coupled to the _Truck_ class. Adding _Ships_ into the app would require making changes to the entire codebase. Moreover, if later you decide to add another type of transportation to the app, you will probably need to make all of these changes again.

As a result, you will end up with pretty nasty code, riddled with conditionals that switch the app’s behavior depending on the class of transportation objects.

**🙂Solution**

The Factory Method pattern suggests that you replace direct object construction calls (using the *new* operator) with calls to a special factory method. Don’t worry: the objects are still created via the *new* operator, but it’s being called from within the factory method. Objects returned by a factory method are often referred to as products.

![image](https://github.com/Hamroliyev/DESIGNPATTERNS/assets/90793925/f0a1812a-4938-4ff3-86ae-3f790abbcede)


