using System;

namespace PizzaStoreAbstractFactory
{
	public class PepperoniPizza : Pizza
	{
		public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
		{
		}

		public override void Prepare()
		{
			Console.WriteLine($"Preparing {Name}");
			_dough = _pizzaIngredientFactory.CreateDough();
			_sauce = _pizzaIngredientFactory.CreateSauce();
			_cheese = _pizzaIngredientFactory.CreateCheese();
			_veggies = _pizzaIngredientFactory.CreateVeggies();
			_pepperoni = _pizzaIngredientFactory.CreatePepperoni();
		}
	}
}