## Overview
This project implements a simple in-memory shopping cart in C# 6.0, and can be completed 
using the free community version of Visual Studio 2015 available here: 
* [https://my.visualstudio.com/Downloads?pid=1881](https://my.visualstudio.com/Downloads?pid=1881) 

No need to implement a UI or DB, just implement the ShoppingCart class using an in memory collection such that all the unit tests pass.

**Estimated Time:** 1-2 hours

**Note:** No forking or pull requests please!! We don't want your solution to be made public on github. Please download the repo as a zip file, and submit your completed solution to daniel.packard@complexrehabsystems.com


## Details
Using an instance of the ShoppingCart class, you should be able to:
* add products to the cart
* remove products from the cart
* remove everything from the cart
* query if the cart is empty
* query if the cart contains any of a given product
* query how many of a given product the cart contains
* query the total value (in $) of the items in the cart

sample usage:
``` c#
var apple = new Product() {Name = "apple", Price = 25};
var banana = new Product() {Name = "banana", Price = 15};
var pineapple = new Product() {Name = "pineapple", Price = 55};

var cart = new ShoppingCart();
cart.IsEmpty(); // returns true

cart.AddProduct(banana, 3);
cart.IsEmpty();               // returns false
cart.contains(banana);        // returns true
cart.Quantity(banana);        // returns 3
cart.contains(apple);         // returns false
cart.Total();                 // returns 45 (15 * 3)

cart.add(pineapple, 1);
cart.contains(pineapple);     // returns true
cart.Total();                 // returns 100 (15 * 3 + 55)

cart.RemoveProduct(banana, 1);// removes one banana
cart.Quantity(banana);        // returns 2
cart.RemoveProduct(banana);   // removes all bananas
cart.Quantity(banana);        // returns 0;

cart.RemoveAll();
cart.IsEmpty();               // returns true;

```

These operations are specified in a set of [unit tests](https://github.com/daniel-packard/ShoppingCart_Interview/blob/master/ShoppingCart_Interview/Test/When_adding_and_removing_items_to_a_shopping_cart.cs), and the functions are stubbed out in the [ShoppingCart](https://github.com/daniel-packard/ShoppingCart_Interview/blob/master/ShoppingCart_Interview/ShoppingCart.cs) class. The project is complete when all unit tests are passing.

## Bonus questions: 
After implementing the solution, you can optionally follow up by addressing some (or all) of these points:
- A) Suggest unit tests that you think should be added.
- B) Propose a way to add the concept of a Discount to the ShoppingCart 
  - e.g. a percentage discount off the cart total, buy one get one free, etc
  - No need to _implement_ Discounts -- this is just to gain insight into your software design thought process.
- C) Propose a database schema that would support the operations used here
  - what if you want to review an old order, but prices have since been updated?

## Tips and Best Practices

* Use modern C# idioms wherever possible (LINQ, lambda expressions, expression body members, etc)
* Avoid using imperative style (loops, if/else, etc)
* Avoid nested logic and unnecessary branching
* When suggesting new tests, especially try to think of edge cases (e.g. what should happen if you try to remove something that is not in the cart? What happens if you try to remove more items than the cart contains?)
* Please take time to refactor if you have duplicated logic
* Optimize for readability/maintainability over performance.

Here is a small sample of the work required to make one test pass:
* [https://github.com/daniel-packard/ShoppingCart_Interview/pull/2/files](https://github.com/daniel-packard/ShoppingCart_Interview/pull/2/files)
