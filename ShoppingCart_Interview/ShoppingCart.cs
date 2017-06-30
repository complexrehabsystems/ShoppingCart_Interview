using System;
using System.Collections.Generic;

namespace ShoppingCart_Interview
{
    public class ShoppingCart
    {
        public void AddProduct(Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        // default quantity of -1 indicates that ALL of the item should be removed
        public void RemoveProduct(Product product, int? quantity = -1)
        {
            throw new NotImplementedException();
        }

        public float Total()
        {
            // dummy implementation to make first unit tests pass
            return 0;
        }

        public bool IsEmpty()
        {
            // dummy implementation to make first unit tests pass
            return true;
        }

        public bool Contains(Product product)
        {
            throw new NotImplementedException();
        }

        public int Quantity(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
