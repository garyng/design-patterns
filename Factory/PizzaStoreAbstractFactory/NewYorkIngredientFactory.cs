namespace PizzaStoreAbstractFactory
{
	public class NewYorkIngredientFactory : IPizzaIngredientFactory
	{
		public Dough CreateDough()
		{
			return new ThinCrustDough();
		}

		public Sauce CreateSauce()
		{
			return new MarinaraSauce();
		}

		public Cheese CreateCheese()
		{
			return new ReggianoCheese();
		}

		public Veggie[] CreateVeggies()
		{
			return new Veggie[] {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Clam CreateClam()
		{
			return new FreshClam();
		}
	}
}