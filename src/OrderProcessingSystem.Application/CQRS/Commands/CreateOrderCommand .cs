using MediatR;

public class CreateOrderCommand : IRequest<Guid>
{
    public string CustomerName { get; set; } = string.Empty;
}
