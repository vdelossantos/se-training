namespace Orders.Services.Order.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Orders.Infrastructure.Logging;
    using Orders.Services.Order.Data;

    public class OrderServiceTest
    {
        private OrderService target;

        private Mock<IOrderDataGateway> gateway;
        private Mock<ILogger> logger;

        [TestInitialize]
        public void Setup()
        {
            this.logger = new Mock<ILogger>();
            this.gateway = new Mock<IOrderDataGateway>();

            this.target = new OrderService(this.gateway.Object, this.logger.Object);
        }

        [TestCleanup]
        public void TearDown()
        {
            this.logger = null;
            this.gateway = null;

            this.target = null;
        }
    }
}
