namespace FruitBasket;
public class FruitBasket
{
    private List<Fruit> fruits;

    public FruitBasket(List<Fruit> fruits)
    {
        this.fruits = fruits;
    }

    public decimal GetTotalCost()
    {
        foreach (var fruit in fruits)
        {
            if(fruit.FruitName == "Apple")
            {
                return fruit.UnitCost * fruit.Quantity;
            }
        }
      
        return 0;
    }
}

