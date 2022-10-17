namespace FruitBasketTests;
using FruitBasket;

public class Tests
{
    private List<Fruit> fruits;
    private decimal costOfBasket;
    private FruitBasket fruitBasket;

    [SetUp]
    public void Setup()
    {
        fruits = new List<Fruit>();
        fruitBasket = new FruitBasket(fruits);
        
    }

    [Test]
    public void WhenBasketIsEmpty_ThenReturnTotalCostAsZero()
    {
        costOfBasket = fruitBasket.GetTotalCost();
        Assert.That(costOfBasket, Is.EqualTo(0));
    }

    [Test]
    public void WhenBasketHasOneApple_ThenReturnTotalCostOfOneApple()
    {
        var apple = new Fruit
        {
            FruitName = "Apple",
            Quantity = 1,
            UnitCost = 0.35m
        };

        fruits.Add(apple);

        costOfBasket = fruitBasket.GetTotalCost();

        Assert.That(costOfBasket, Is.EqualTo(0.35m));

    }

    [Test]
    public void WhenBasketHasFiveApple_ThenReturnTotalCostOfFiveApple()
    {
        var apple = new Fruit
        {
            FruitName = "Apple",
            Quantity = 5,
            UnitCost = 0.35m
        };

        fruits.Add(apple);

        costOfBasket = fruitBasket.GetTotalCost();

        Assert.That(costOfBasket, Is.EqualTo(1.75m));

    }

}

