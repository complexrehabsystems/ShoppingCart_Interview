## Overview
This project implements a simple in-memory shopping cart using modern C#6 or C#7. The project can be completed 
using the free community version of Visual Studio 2015 available here: 
* [https://www.visualstudio.com/vs/community/](https://www.visualstudio.com/vs/community/) 

Implement the ShoppingCart class using an in memory collection of Products such that 
all the unit tests pass. There is no need to implement a DB schema, or command line interface, etc.

**Estimated Time:** 1-4 hours

**Note:** No forking or pull requests please!! We don't want your solution to be made public on 
github. Please download the repo as a zip file, and submit your completed solution as a zip file 
to daniel.packard@complexrehabsystems.com


## Details
The project is complete when all of the provided 
[unit tests](https://github.com/complexrehabsystems/ShoppingCart_Interview/blob/master/ShoppingCart_Interview/Test/When_adding_and_removing_items_to_a_shopping_cart.cs)
pass. 

The unit tests specifiy the following funcitonality in detail:
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
* When suggesting new tests, especially try to think of edge cases 
  * (e.g. what should happen if you try to remove something that is not in the cart? What happens if you try to remove more items than the cart contains?)
* Please take time to refactor if you have duplicated logic
* Optimize for readability/maintainability over performance.