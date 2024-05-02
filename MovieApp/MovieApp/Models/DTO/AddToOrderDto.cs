namespace MovieApp.Models.DTO
{
    public class AddToOrderDto
    {
        public Guid SelectedTicketId { get; set; }
        public int Quantity { get; set; }

    }
}
