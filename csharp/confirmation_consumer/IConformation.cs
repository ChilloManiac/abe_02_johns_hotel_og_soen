namespace confirmation_consumer
{
    public interface IConformation
    {
        public bool success { get; set; }
        public string hotelName { get; set; }
        public int roomNumber { get; set; }
    }
}