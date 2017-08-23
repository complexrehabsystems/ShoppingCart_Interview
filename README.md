This project implements a simple shopping cart in C# 6.0, and can be completed 
using the free community version of Visual Studio 2015 available here: 
* [https://my.visualstudio.com/Downloads?pid=1881](https://my.visualstudio.com/Downloads?pid=1881) 

Using an instance of the ShoppingCart class, you should be able to:
* add products to the cart
* remove products from the cart
* remove everything from the cart
* query if the cart is empty
* query if the cart contains any of a given product
* query how many of a given product the cart contains

sample usage:
``` c#
var apple = new Product() {Name = "apple", Price = 25};
var banana = new Product() {Name = "banana", Price = 15};
var pineapple = new Product() {Name = "pineapple", Price = 55};

var cart = new ShoppingCart();
cart.IsEmpty(); // returns true

cart.AddProduct(banana, 3);
cart.IsEmpty(); // returns false
cart.contains(banana); // returns true
cart.contains(apple); // returns false
cart.Total(); // returns 45

cart.add(pineapple, 1);
cart.Total(); // returns 100

cart.RemoveProduct(banana, 1);
cart.Quantity(banana); // returns 2
cart.RemoveProduct(banana);
cart.Quantity(banana); // returns 0;

cart.RemoveAll();
cart.IsEmpty(); // returns true;

```

These operations are specified in a set of unit tests, and the project is complete when all unit tests are passing.

After implementing code to pass all of the provided tests, please:
- A) Suggest unit tests that you think should be added.
- B) Propose a way to add the generalized concept of a Discount to the ShoppingCart 
  - e.g. percentage off cart total, buy one get one free, etc
  - No need to implement Discounts -- this is just to gain insight into your software design thought process.
