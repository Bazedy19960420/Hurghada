namespace Hurghada.Core.Features.Properties.Queries.Responses
{
    public class GetPropertyListResponse
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int DownPayment { get; set; }
        public int MonthlyPayment { get; set; }
        public int DailyPayment { get; set; }
        public int BedRooms { get; set; }
        public int PathRooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsFurnished { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsApproved { get; set; }
        public string PropertyTypeName { get; set; } = string.Empty;
        public List<PropertyAmenitiesResponse> PropertyAmenities { get; set; } = new List<PropertyAmenitiesResponse>();
    }
    public class PropertyAmenitiesResponse
    {
        public string AmenityName { get; set; } = string.Empty;
    }
}
