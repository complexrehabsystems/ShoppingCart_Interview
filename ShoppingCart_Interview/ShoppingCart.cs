using System;
using System.Collections.Generic;

namespace ShoppingCart_Interview
{
    public class ShoppingCart
    {
        // add the specified quantity of item 'product' to the cart
        public void AddProduct(Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        // remove the specified quantity of item 'product' from the cart
        // default quantity of -1 indicates that ALL items of type 'product' should be removed
        public void RemoveProduct(Product product, int quantity = -1)
        {
            throw new NotImplementedException();
        }

        // return the total $ value of items in the cart
        public float Total()
        {
            // dummy implementation to make first unit tests pass
            return 0;
        }

        // return true if the cart is empty, false otherwise
        public bool IsEmpty()
        {
            // dummy implementation to make first unit tests pass
            return true;
        }

        // return true if the cart contains any items of type "product", false otherwise
        public bool Contains(Product product)
        {
            throw new NotImplementedException();
        }

        // returns the quantity of items of type 'product' contained in the cart
        public int Quantity(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
