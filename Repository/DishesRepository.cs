using Microsoft.EntityFrameworkCore;

namespace JaegarRestoAPI;

public class DishesRepository : IDishesRepository
{
  private readonly JaegarRestoContext _context;

  public DishesRepository(JaegarRestoContext context){
    _context = context;
  }

  public async Task<Dish> GetDishByIdAsync(string id)
  {
    return await this._context.Dishes.FindAsync(id);
  }

  public async Task<IReadOnlyList<Dish>> GetDishesAsync()
  {
    return await this._context.Dishes.ToListAsync();
  }

  public async Task<Dish> CreateNewDishAsync(Dish dish)
  {
    if(string.IsNullOrEmpty(dish.Id)) {
      dish.Id = Guid.NewGuid().ToString();
    }
    
    this._context.Dishes.Add(dish);

    await this._context.SaveChangesAsync();

    return dish;
  }
}