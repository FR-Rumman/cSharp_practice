using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            // Arrange
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            var order = new Order
            {
                IsShipped = true
            };

            // Act & Assert
            Assert.ThrowsException<InvalidOperationException>(
                () => orderProcessor.Process(order)
            );
        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}