using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Reflection;

namespace Module16._2.UserTicketService.Tests
{
    //// Screencast 16.5
    //[TestFixture]
    //public class TicketServiceIntegrationTests
    //{
    //    [Test]
    //    public void SaveTicketMustAddTicketInBase()
    //    {
    //        var ticketServiceTest = new TicketService();
    //        var newTicket = new Ticket(300, "Test ticket", 1000);

    //        ticketServiceTest.SaveTicket(newTicket);

    //        var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
    //        CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

    //        //16.6
    //        //ticketServiceTest.DeleteTicket(newTicket);
    //        PrivateObject obj = new PrivateObject(ticketServiceTest);

    //        obj.Invoke("DeleteTicket", newTicket);

    //        var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
    //        CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
    //    }
    //}
    // Screencast 16.6
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicket()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            //PrivateObject obj = new PrivateObject(ticketServiceTest);
            //obj.Invoke("DeleteTicket", newTicket);
            
            Type t = typeof(TicketService);
            t.InvokeMember("DeleteTicket",
                BindingFlags.InvokeMethod |
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Instance,
                null, ticketServiceTest, new[] { newTicket });

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
