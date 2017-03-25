using System;

namespace PizzaStoreAbstractFactory
{
	public class VeggiePizza : Pizza
	{
		public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine($"Preparing {Name}");
			_dough = _pizzaIngredientFactory.CreateDough();
			_sauce = _pizzaIngredientFactory.CreateSauce();
			_cheese = _pizzaIngredientFactory.CreateCheese();
			_veggies = _pizzaIngredientFactory.CreateVeggies();
		}
	}
}