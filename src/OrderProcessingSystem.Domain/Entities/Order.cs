using OrderProcessingSystem.Domain.Enums;

namespace OrderService.Domain.Entities;



public class Order
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderEvent> Events { get; set; } = new();
}
