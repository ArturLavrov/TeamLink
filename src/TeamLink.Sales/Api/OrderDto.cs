namespace TeamLink.Sales.Api;

public record OrderDto
{
    public string Id { get; set; }
    public string Status { get; set; }
}