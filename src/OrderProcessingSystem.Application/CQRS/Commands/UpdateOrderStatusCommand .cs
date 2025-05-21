using MediatR;
using OrderProcessingSystem.Domain.Enums;
using OrderService.Domain.Entities;

public class UpdateOrderStatusCommand : IRequest
{
    public Guid OrderId { get; set; }
    public OrderStatus NewStatus { get; set; }
}
