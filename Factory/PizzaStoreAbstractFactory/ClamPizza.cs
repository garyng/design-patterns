using System;

namespace PizzaStoreAbstractFactory
{
	public class ClamPizza : Pizza
	{
		public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine($"Preparing {Name}");
			_dough = _pizzaIngredientFactory.CreateDough();
			_sauce = _pizzaIngredientFactory.CreateSauce();
			_cheese = _pizzaIngredientFactory.CreateCheese();
			_clam = _pizzaIngredientFactory.CreateClam();

		}
	}
}