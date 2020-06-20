The Factory method takes care of one product whereas the abstract factory pattern provides a way to encapsulate a family of products. This pattern is used to create concrete class instances without specifying the exact class type. We can say it is an Object creation pattern also. Here objects are created without knowing the class of the object. So basically the factory pattern is used wherever the sub classes are given the previledge of instantiating a method that can create an object.

The Factory pattern consist of:
- *AbstractFactory (File)* - it declates the operations on abstract objects, _CreateItemss_ method
- *AbstractProduct (Item)* - it declares the type of the product, in this example it is empty
- *ConcreteFactory (Furniture, Crokery)* - declates the operations on specific items, overrides the  _CreateItemss_ method
- *Product (PlatesItems, GlassesItems, TeasetItems, BowlsItems, SofasetItems, BedItems, DiningItems)* - defines the specific object, all specific objects should implement the abstract one
- *Client(Example)* - uses the interfaces _File_ and _Item_