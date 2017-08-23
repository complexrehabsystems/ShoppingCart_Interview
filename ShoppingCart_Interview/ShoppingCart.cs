using System;
using System.Collections.Generic;

namespace ShoppingCart_Interview
{
    public class ShoppingCart
    {
        // Add the specified quantity of 'product' to the cart.
        // If no quantity is specified, one 'product' should be added.
        public void AddProduct(Product product, int quantity = 1)
        {
            throw new NotImplementedException();
        }

        // Remove the specified quantity of 'product' from the cart.
        // If no quantity is specified, remove all 'product' from the cart.
        public void RemoveProduct(Product product, int? quantity = null)
        {
            throw new NotImplementedException();
        }


        // Remove everything from the cart.
        public void RemoveEverything()
        {
            throw new NotImplementedException();
        }

        // Return the total $ value of the cart's content.
        public float Total()
        {
            return 0;
        }

        // Return true if the cart is empty, false otherwise.
        public bool IsEmpty()
        {
            return true;
        }

        // Return true if the cart contains any items of type "product", false otherwise.
        public bool Contains(Product product)
        {
            throw new NotImplementedException();
        }

        // Returns the quantity of 'product' contained in the cart
        public int Quantity(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
