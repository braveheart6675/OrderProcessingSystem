using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    #region Members
        private readonly IMediator _mediator;
    #endregion

    #region Ctor
    public OrdersController(IMediator mediator) => _mediator = mediator;
    #endregion

    #region Public Members
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand cmd)
    {
        var id = await _mediator.Send(cmd);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _mediator.Send(new GetOrderByIdQuery(id));
        return Ok(result);
    }

    [HttpPatch("{id}/status")]
    public async Task<IActionResult> UpdateStatus(Guid id, [FromBody] UpdateOrderStatusCommand cmd)
    {
        cmd.OrderId = id;
        await _mediator.Send(cmd);
        return NoContent();
    }
    #endregion
}
