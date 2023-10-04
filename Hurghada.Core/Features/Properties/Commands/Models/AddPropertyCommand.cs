using Hurghada.Core.Bases;
using MediatR;

namespace Hurghada.Core.Features.Properties.Commands.Models
{
    public class AddPropertyCommand : IRequest<Response<string>>
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
        public int PropertyTypeId { get; set; }
        public List<int> PropertyAmenities { get; set; } = new List<int>();
    }
}
