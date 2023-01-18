using Microsoft.AspNetCore.Mvc;

namespace JaegarRestoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DishesController : ControllerBase
{
    private readonly IDishesRepository _repository;

    public DishesController(IDishesRepository repository) {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Dish>>> GetDishes() {
        var dishes = await this._repository.GetDishesAsync();

        return Ok(dishes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dish>> GetDish(string id) {
        var dish = await this._repository.GetDishByIdAsync(id);

        return Ok(dish);
    }

    [HttpPost]
    public async Task<ActionResult<Dish>> CreateDish([FromBody] Dish dish){
        var createdDish = await this._repository.CreateNewDishAsync(dish);

        return Ok(createdDish);
    }
}
