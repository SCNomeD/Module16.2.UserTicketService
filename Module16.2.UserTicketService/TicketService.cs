namespace Module16._2.UserTicketService
{
    public class TicketService : ITicketService
    {
        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
                throw new TicketNotFoundException() : ticket.Id;
        }

        public Ticket GetTicket(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
              throw new TicketNotFoundException() : ticket;
        }

        // Screencast 16.5
        public void SaveTicket(Ticket ticket)
        {
            FakeBaseData.Add(ticket);
        }

        // 16.6 замена public на private
        private void DeleteTicket(Ticket ticket)
        {
            FakeBaseData.Remove(ticket);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return FakeBaseData;
        }

        private List<Ticket> FakeBaseData = new List<Ticket>
        {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
        };
    }
}
