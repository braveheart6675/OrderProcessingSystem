using MediatR;

public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public Guid OrderId { get; }
    public GetOrderByIdQuery(Guid orderId) => OrderId = orderId;
}
