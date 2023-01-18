namespace JaegarRestoAPI;

public interface IDishesRepository { 

  Task<Dish> GetDishByIdAsync(string id);

  Task<IReadOnlyList<Dish>> GetDishesAsync();

  Task<Dish> CreateNewDishAsync(Dish dish);
}