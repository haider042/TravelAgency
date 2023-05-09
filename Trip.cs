namespace Travelia.Model
{
    public class Trip
    {


        public int Id { get; set; }
        public string? Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
    }
}
