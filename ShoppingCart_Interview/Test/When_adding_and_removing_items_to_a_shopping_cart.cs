using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ShoppingCart_Interview.Test
{
    [TestFixture]
    class When_adding_and_removing_items_in_a_shopping_cart
    {
        private ShoppingCart _cart;
        private List<Product> _testProducts;


        // A set of test products is created once, and shared by all tests in this [TestFixture]
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

        // A new cart is created before every [Test]
        [SetUp]
        public void Setup()
        {
            _cart = new ShoppingCart();
        }

        [Test]
        public void a_new_cart_should_be_empty()
        {
            Assert.True(_cart.IsEmpty());
        }


        [Test]
        public void a_new_cart_total_should_be_zero()
        {
            Assert.AreEqual(0, _cart.Total());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A__the_cart_should_not_be_empty()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 1);

            // Assert
            Assert.IsFalse(_cart.IsEmpty());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A__the_cart_should_contain_product_A()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 1);

            // Assert
            Assert.IsTrue(_cart.Contains(productA));
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_two_product_A__the_cart_should_contain_two_product_A()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 2);

            // Assert
            Assert.AreEqual(2, _cart.Quantity(productA));
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A_and_then_two_product_A__the_cart_should_contain_three_product_A()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 1);
            _cart.AddProduct(productA, 2);

            // Assert
            Assert.AreEqual(3, _cart.Quantity(productA));
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_and_removing_one_product_A__the_cart_should_NOT_contain_any_product_A()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 1);
            _cart.RemoveProduct(productA, 1);

            // Assert
            Assert.IsFalse(_cart.Contains(productA));
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A__the_cart_total_should_be_correct()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 1);

            // Assert
            var expectedTotal = productA.Price * 1;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_two_product_A__the_cart_total_should_be_correct()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 2);

            // Assert
            var expectedTotal = productA.Price * 2;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A_and_two_product_b__the_cart_total_should_be_correct()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");
            var productB = _testProducts.Single(p => p.Name == "B");

            // Act
            _cart.AddProduct(productA, 1);

            // Assert
            var expectedTotal = productA.Price * 1 + productB.Price * 2;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void after_adding_one_product_A_two_product_B_and_three_product_C__the_cart_total_should_be_correct()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");
            var productB = _testProducts.Single(p => p.Name == "B");
            var productC = _testProducts.Single(p => p.Name == "C");

            // Act
            _cart.AddProduct(productA, 1);
            _cart.AddProduct(productB, 2);
            _cart.AddProduct(productC, 3);

            // Assert
            var expectedTotal = productA.Price * 1 + productB.Price * 2 + productC.Price * 3;
            Assert.AreEqual(expectedTotal, _cart.Total());
        }

        [Test]
        [Ignore("Remove this ignore attribute when you are ready to run this test.")]
        public void calling_remove_product_with_no_quantity_will_remove_all_of_the_given_product_from_the_cart()
        {
            // Arrange
            var productA = _testProducts.Single(p => p.Name == "A");

            // Act
            _cart.AddProduct(productA, 5);
            _cart.RemoveProduct(productA);

            // Assert
            Assert.IsTrue(_cart.IsEmpty());
        }

    }
}
