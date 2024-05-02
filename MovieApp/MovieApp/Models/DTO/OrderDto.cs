namespace MovieApp.Models.DTO
{
    public class OrderDto
    {
        public List<TicketInOrder>? AllTickets { get; set; }
        public double TotalPrice { get; set; }

    }
}
