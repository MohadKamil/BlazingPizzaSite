using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[ApiController]
[Route("specials")]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _context;

    public SpecialsController(PizzaStoreContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PizzaSpecial>>> GetSpecials()
    {
        return (await _context.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}