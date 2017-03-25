namespace PizzaStoreAbstractFactory
{
	public class ChicagoIngredientFactory : IPizzaIngredientFactory
	{
		public Dough CreateDough()
		{
			return new ThickCrustDough();
		}

		public Sauce CreateSauce()
		{
			return new PlumTomatoSauce();
		}

		public Cheese CreateCheese()
		{
			return new MozzarellaCheese();
		}

		public Veggie[] CreateVeggies()
		{
			return new Veggie[] {new BlackOlives(), new Spinach(), new Eggplant()};
		}

		public Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public Clam CreateClam()
		{
			return new FrozenClams();
		}
	}
}