using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ShoppingCart_Interview.Test
{
    [TestFixture]
    class When_adding_and_removing_items_to_a_shopping_cart
    {
        private ShoppingCart _cart;
        private List<Product> _testProducts;

        [OneTimeSetUp]
        public void SetupFixture()
        {
            _testProducts = new List<Product>()
            {
                new Product() {Name = "A", Price = 15},
                new Product() {Name = "B", Price = 25},
                new Product() {Name = "C", Price = 35}
            };
        }

        [SetUp]
        public void Setup()
        {
            // new cart is created before each test.
            _cart = new ShoppingCart();
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void a_new_cart_should_be_empty()
        {
            Assert.True(_cart.IsEmpty());
        }


        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void a_new_cart_total_should_be_zero()
        {
            var expectedTotal = 0;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A__the_cart_should_not_be_empty()
        {
            _cart.AddProduct(ProductA, 1);

            Assert.IsFalse(_cart.IsEmpty());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A__the_cart_should_contain_product_A()
        {
            _cart.AddProduct(ProductA, 1);

            Assert.IsTrue(_cart.Contains(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A__the_cart_should_contain_one_product_A()
        {
            _cart.AddProduct(ProductA, 1);

            var expectedQuantity = 1;
            Assert.AreEqual(expectedQuantity, _cart.Quantity(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_product_A_with_no_quantity_specified__the_cart_should_contain_one_product_A()
        {
            _cart.AddProduct(ProductA);

            var expectedQuantity = 1;
            Assert.AreEqual(expectedQuantity, _cart.Quantity(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A__the_cart_should_not_contain_product_B()
        {
            _cart.AddProduct(ProductA, 1);

            Assert.IsFalse(_cart.Contains(ProductB));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_two_product_A__the_cart_should_contain_two_product_A()
        {
            _cart.AddProduct(ProductA, 2);

            var expectedQuantity = 2;
            Assert.AreEqual(expectedQuantity, _cart.Quantity(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A_and_then_two_product_A__the_cart_should_contain_three_product_A()
        {
            _cart.AddProduct(ProductA, 1);
            _cart.AddProduct(ProductA, 2);

            var expectedQuantity = 3;
            Assert.AreEqual(expectedQuantity, _cart.Quantity(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_and_removing_one_product_A__the_cart_should_NOT_contain_any_product_A()
        {
            _cart.AddProduct(ProductA, 1);
            _cart.RemoveProduct(ProductA, 1);

            Assert.IsFalse(_cart.Contains(ProductA));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A__the_cart_total_should_be_correct()
        {
            _cart.AddProduct(ProductA, 1);

            var expectedTotal = ProductA.Price * 1;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_two_product_A__the_cart_total_should_be_correct()
        {
            _cart.AddProduct(ProductA, 2);

            var expectedTotal = ProductA.Price * 2;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A_and_two_product_b__the_cart_total_should_be_correct()
        {
            _cart.AddProduct(ProductA, 1);
            _cart.AddProduct(ProductB, 2);

            var expectedTotal = ProductA.Price * 1 + ProductB.Price * 2;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A_and_two_product_b__and_then_removing_one_product_A__the_cart_should_contain_two_product_B()
        {
            _cart.AddProduct(ProductA, 1);
            _cart.AddProduct(ProductB, 2);

            _cart.RemoveProduct(ProductA, 1);

            var expectedQuantityOfB = 2;
            Assert.AreEqual(expectedQuantityOfB, _cart.Quantity(ProductB));
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void after_adding_one_product_A_two_product_B_and_three_product_C__the_cart_total_should_be_correct()
        {
            _cart.AddProduct(ProductA, 1);
            _cart.AddProduct(ProductB, 2);
            _cart.AddProduct(ProductC, 3);

            var expectedTotal = ProductA.Price * 1 + ProductB.Price * 2 + ProductC.Price * 3;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove one Ignore attribute at a time")]
        public void calling_remove_product_with_no_quantity_should_remove_all_of_the_given_product_from_the_cart()
        {
            _cart.AddProduct(ProductA, 5);
            _cart.RemoveProduct(ProductA);

            Assert.IsTrue(_cart.IsEmpty());
        }

        [Test]
        public void after_adding_items_to_the_cart_and_calling_remove_everything__the_cart_should_be_empty()
        {
            _cart.AddProduct(ProductA, 5);
            _cart.AddProduct(ProductB, 2);
            _cart.AddProduct(ProductC, 3);
            _cart.RemoveEverything();

            Assert.IsTrue(_cart.IsEmpty());
        }

#region Convenience Methods
        private Product ProductA => _testProducts.Single(p => p.Name == "A");
        private Product ProductB => _testProducts.Single(p => p.Name == "B");
        private Product ProductC => _testProducts.Single(p => p.Name == "C");
#endregion


    }
}
