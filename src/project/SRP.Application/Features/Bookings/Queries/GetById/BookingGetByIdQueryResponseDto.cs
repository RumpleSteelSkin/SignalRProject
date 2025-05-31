namespace SRP.Application.Features.Bookings.Queries.GetById;

public class BookingGetByIdQueryResponseDto
{
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? Description { get; set; }
    public int? PersonCount { get; set; }
    public DateTime Date { get; set; }
}