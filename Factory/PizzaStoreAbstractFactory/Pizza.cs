using System;

namespace PizzaStoreAbstractFactory
{
	public abstract class Pizza
	{
		protected readonly IPizzaIngredientFactory _pizzaIngredientFactory;
		public virtual string Name { get; set; } = "Unknown Pizza";
		protected Dough _dough;
		protected Sauce _sauce;
		protected Veggie[] _veggies;
		protected Cheese _cheese;
		protected Pepperoni _pepperoni;
		protected Clam _clam;

		public Pizza(IPizzaIngredientFactory pizzaIngredientFactory)
		{
			_pizzaIngredientFactory = pizzaIngredientFactory;
		}

		public abstract void Prepare();

		public virtual void Bake()
		{
			Console.WriteLine("Baking...");
		}

		public virtual void Cut()
		{
			Console.WriteLine("Cutting...");
		}

		public virtual void Box()
		{
			Console.WriteLine("Boxing...");
		}

		public override string ToString()
		{
			return $"--- {Name} ---" +
			       (_dough == null ? "" : $"\nDough: {_dough}") +
			       (_sauce == null ? "" : $"\nSauce: {_sauce}") +
			       (_cheese == null ? "" : $"\nCheese: {_cheese}") +
			       (_pepperoni == null ? "" : $"\nPepperoni: {_pepperoni}") +
			       (_clam == null ? "" : $"\nClam: {_clam}") +
			       (_veggies == null ? "" : $"\nVeggies: {string.Join<Veggie>(", ", _veggies)}") +
			       $"\n--- {Name} ---";
		}
	}
}