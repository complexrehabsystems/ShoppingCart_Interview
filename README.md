## Overview
This project implements a simple shopping cart in C# 6.0, and can be completed 
using the free community version of Visual Studio 2015 available here: 
* [https://my.visualstudio.com/Downloads?pid=1881](https://my.visualstudio.com/Downloads?pid=1881) 

**Estimated Time:** 1-2 hours

## Details
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

All cart operations are specified in a set of unit tests, and the project is complete when all unit tests are passing.

BONUS: After implementing code to pass the provided tests, you can optionally follow up by addressing some (or all) of these points:
- A) Suggest unit tests that you think should be added.
- B) Propose a way to add the concept of a Discount to the ShoppingCart 
  - e.g. a percentage discount off the cart total, buy one get one free, etc
  - No need to _implement_ Discounts -- this is just to gain insight into your software design thought process.
- C) Propose a database schema that would support the operations used here

## Tips and Best Practices

* Use modern C# idioms whereever possible (LINQ, lambda expressions, expression body members, etc)
* Avoid using imperative style (loops, if/else, etc)
* Avoid nested logic and unnecessary branching
* When suggesting new tests, especially try to think of edge cases (e.g. what should happen if you try to remove something that is not in the cart?)
* Take time to refactor if you have duplicated logic
* Optimize for readability/maintainability over performance.

Here is a small example of the work required to make one small test pass:
* [https://github.com/daniel-packard/ShoppingCart_Interview/pull/2/files](https://github.com/daniel-packard/ShoppingCart_Interview/pull/2/files)
