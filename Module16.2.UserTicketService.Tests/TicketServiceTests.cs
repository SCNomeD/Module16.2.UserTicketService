using Moq;
using NUnit.Framework;

namespace Module16._2.UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        // 16.4
        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicket(1));
        }
    }

    [TestFixture]
    public class TicketPriceTests
    {
        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            // Данной строкой мы создали moq-объект с типом ITicketService:
            var mockTicketService = new Mock<ITicketService>();
            // Данные строки выполняют конфигурацию нашего объекта moq.
            // Конкретнее, они устанавливают возвращаемое значение при определенных запросах:
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }
    }
}
