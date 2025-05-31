namespace SRP.Application.Features.Bookings.Queries.GetAll;

public class BookingGetAllQueryResponseDto
{
    public required int Id { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Mail { get; set; }
    public string? Description { get; set; }
    public int? PersonCount { get; set; }
    public DateTime Date { get; set; }
}