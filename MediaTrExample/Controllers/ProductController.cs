using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MediaTrExample.Med.Queries;

namespace MediaTrExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var query = new GetProductByIdQuery(){ Id = id };
        return Ok(await _mediator.Send(query));
    }

    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllProductQuery(){};
        return Ok(await _mediator.Send(query));
    }

    [HttpPost()]
    public async Task<IActionResult> Post(CreateProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}
