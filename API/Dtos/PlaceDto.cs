namespace API.Dtos
{
    public class PlaceDto
    {
        public int IdPlace { get; set; }
        public string Name { get; set; }
        public decimal ApproximateExpenses { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public String Category { get; set; }
        public string Country { get; set; }
    }
}
