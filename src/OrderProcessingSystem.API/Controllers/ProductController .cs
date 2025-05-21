using Microsoft.AspNetCore.Mvc;
using OrderProcessingSystem.Domain.Entities;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    #region Private Member
    private readonly IProductRepository _repo;
    private readonly ILogger<ProductController> _logger;
    #endregion

    #region Ctor
    public ProductController(IProductRepository repo, ILogger<ProductController> logger)
    {
        _repo = repo;
        _logger = logger;
    }
    #endregion

    #region Public Members
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _repo.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var product = await _repo.GetByIdAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Product product)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        await _repo.AddAsync(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Product updated)
    {
        if (id != updated.Id || !ModelState.IsValid) return BadRequest();
        if (!await _repo.ExistsAsync(id)) return NotFound();

        await _repo.UpdateAsync(updated);
        return NoContent();
    }
    #endregion
}
