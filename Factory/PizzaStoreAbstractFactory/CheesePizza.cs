using System;

namespace PizzaStoreAbstractFactory
{
	public class CheesePizza : Pizza
	{
		public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine($"Preparing {Name}");
			_dough = _pizzaIngredientFactory.CreateDough();
			_sauce = _pizzaIngredientFactory.CreateSauce();
			_cheese = _pizzaIngredientFactory.CreateCheese();
		}
	}
}