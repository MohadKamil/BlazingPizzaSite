namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        return new[]
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Italiano",
                Vegetarian = false,
                Description = "Authenticate italy Pizza",
                Price = 15,
                Vegan = false
            }
        };
    }
}