namespace PizzaStoreAbstractFactory
{
	public interface IPizzaIngredientFactory
	{
		Dough CreateDough();
		Sauce CreateSauce();
		Cheese CreateCheese();
		Veggie[] CreateVeggies();
		Pepperoni CreatePepperoni();
		Clam CreateClam();
	}
}