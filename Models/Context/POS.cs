namespace signalrserver.Models.Context
{
    public partial class POS
    {

        public long POSId { get; set; }
        public long? VendorId { get; set; }
        public string SerialNumber { get; set; }
        public int? VendorType { get; set; }
        public string Phone { get; set; }
        public bool? Enabled { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? Balance { get; set; }
    }
}
