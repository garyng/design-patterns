using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMenu
{
	class Program
	{
		static void Main(string[] args)
		{
			new WaitressTest().Run();
			Console.ReadKey();
		}
	}

	public class WaitressTest
	{
		public void Run()
		{
			MenuComponent pancakeHouseMenu =
				new Menu("PANCAKE HOUSE MENU", "Breakfast");
			MenuComponent dinerMenu =
				new Menu("DINER MENU", "Lunch");
			MenuComponent cafeMenu =
				new Menu("CAFE MENU", "Dinner");
			MenuComponent dessertMenu =
				new Menu("DESSERT MENU", "Dessert of course!");
			MenuComponent coffeeMenu = new Menu("COFFEE MENU", "Stuff to go with your afternoon coffee");

			MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

			pancakeHouseMenu.Add(new MenuItem(
				"K&B's Pancake Breakfast",
				"Pancakes with scrambled eggs, and toast",
				true,
				2.99));
			pancakeHouseMenu.Add(new MenuItem(
				"Regular Pancake Breakfast",
				"Pancakes with fried eggs, sausage",
				false,
				2.99));
			pancakeHouseMenu.Add(new MenuItem(
				"Blueberry Pancakes",
				"Pancakes made with fresh blueberries, and blueberry syrup",
				true,
				3.49));
			pancakeHouseMenu.Add(new MenuItem(
				"Waffles",
				"Waffles, with your choice of blueberries or strawberries",
				true,
				3.59));

			dinerMenu.Add(new MenuItem(
				"Vegetarian BLT",
				"(Fakin') Bacon with lettuce & tomato on whole wheat",
				true,
				2.99));
			dinerMenu.Add(new MenuItem(
				"BLT",
				"Bacon with lettuce & tomato on whole wheat",
				false,
				2.99));
			dinerMenu.Add(new MenuItem(
				"Soup of the day",
				"A bowl of the soup of the day, with a side of potato salad",
				false,
				3.29));
			dinerMenu.Add(new MenuItem(
				"Hotdog",
				"A hot dog, with saurkraut, relish, onions, topped with cheese",
				false,
				3.05));
			dinerMenu.Add(new MenuItem(
				"Steamed Veggies and Brown Rice",
				"Steamed vegetables over brown rice",
				true,
				3.99));

			dinerMenu.Add(new MenuItem(
				"Pasta",
				"Spaghetti with Marinara Sauce, and a slice of sourdough bread",
				true,
				3.89));

			dessertMenu.Add(new MenuItem(
				"Apple Pie",
				"Apple pie with a flakey crust, topped with vanilla icecream",
				true,
				1.59));

			dessertMenu.Add(new MenuItem(
				"Cheesecake",
				"Creamy New York cheesecake, with a chocolate graham crust",
				true,
				1.99));
			dessertMenu.Add(new MenuItem(
				"Sorbet",
				"A scoop of raspberry and a scoop of lime",
				true,
				1.89));

			cafeMenu.Add(new MenuItem(
				"Veggie Burger and Air Fries",
				"Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
				true,
				3.99));
			cafeMenu.Add(new MenuItem(
				"Soup of the day",
				"A cup of the soup of the day, with a side salad",
				false,
				3.69));
			cafeMenu.Add(new MenuItem(
				"Burrito",
				"A large burrito, with whole pinto beans, salsa, guacamole",
				true,
				4.29));


			coffeeMenu.Add(new MenuItem(
				"Coffee Cake",
				"Crumbly cake topped with cinnamon and walnuts",
				true,
				1.59));
			coffeeMenu.Add(new MenuItem(
				"Bagel",
				"Flavors include sesame, poppyseed, cinnamon raisin, pumpkin",
				false,
				0.69));
			coffeeMenu.Add(new MenuItem(
				"Biscotti",
				"Three almond or hazelnut biscotti cookies",
				true,
				0.89));

			dinerMenu.Add(dessertMenu);
			cafeMenu.Add(coffeeMenu);

			allMenus.Add(pancakeHouseMenu);
			allMenus.Add(dinerMenu);
			allMenus.Add(cafeMenu);

			Waitress waitress = new Waitress(allMenus);
			Console.WriteLine("--- Vegetarian Menu ---");
			waitress.PrintVegetarianMenu(allMenus);
			//waitress.PrintVegetarianMenu();
		}
	}

	public class Waitress
	{
		private readonly MenuComponent _allMenus;

		public Waitress(MenuComponent allMenus)
		{
			_allMenus = allMenus;
		}

		public void PrintMenu()
		{
			Console.WriteLine(_allMenus);
		}

		// local function?
		public void PrintVegetarianMenu(MenuComponent mc)
		{
			foreach (MenuComponent menu in mc)
			{
				if (menu is Menu)
				{
					PrintVegetarianMenu(menu);
				}
				else if (menu.IsVegetarian())
				{
					Console.WriteLine(menu);
				}
			}
		}

		//public void PrintVegetarianMenu()
		//{
		//	Console.WriteLine("--- Vegetarian Menu ---");
		//	printMenu(_allMenus);

		//	void printMenu(MenuComponent mc)
		//	{
		//		foreach (MenuComponent menu in mc)
		//		{
		//			if(menu is Menu)
		//			{
		//				printMenu(menu);
		//			}
		//			else if (menu.IsVegetarian())
		//			{
		//				// a menu item
		//				Console.WriteLine(menu);
		//			}
		//		}
		//	}
		//}
	}

	public abstract class MenuComponent : IEnumerable<MenuComponent>
	{
		public virtual void Add(MenuComponent menuComponent)
		{
			throw new NotSupportedException();
		}

		public virtual void Remove(MenuComponent menuComponent)
		{
			throw new NotSupportedException();
		}

		public virtual MenuComponent GetChild(int index)
		{
			throw new NotSupportedException();
		}

		public virtual string GetName()
		{
			throw new NotSupportedException();
		}

		public virtual string GetDescription()
		{
			throw new NotSupportedException();
		}

		public virtual double GetPrice()
		{
			throw new NotSupportedException();
		}

		public virtual bool IsVegetarian()
		{
			throw new NotSupportedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public virtual IEnumerator<MenuComponent> GetEnumerator()
		{
			throw new NotSupportedException();
		}
	}

	public class MenuItem : MenuComponent
	{
		private string _name;
		private string _description;
		private bool _isVegetarian;
		private double _price;

		public MenuItem(string name, string description, bool isVegetarian, double price)
		{
			_name = name;
			_description = description;
			_isVegetarian = isVegetarian;
			_price = price;
		}

		public override string GetName()
		{
			return _name;
		}

		public override string GetDescription()
		{
			return _description;
		}

		public override double GetPrice()
		{
			return _price;
		}

		public override bool IsVegetarian()
		{
			return _isVegetarian;
		}

		public override string ToString()
		{
			return $"  {GetName()}{(IsVegetarian() ? " (v)" : "")}, {GetPrice()}\n\t{GetDescription()}";
		}

		public override IEnumerator<MenuComponent> GetEnumerator()
		{
			return new NullEnumerator();
		}
	}

	public class Menu : MenuComponent
	{
		private string _name;
		private string _description;
		private List<MenuComponent> _menuComponents = new List<MenuComponent>();

		public Menu(string name, string description)
		{
			_name = name;
			_description = description;
		}

		public override void Add(MenuComponent menuComponent)
		{
			_menuComponents.Add(menuComponent);
		}

		public override void Remove(MenuComponent menuComponent)
		{
			_menuComponents.Remove(menuComponent);
		}

		public override MenuComponent GetChild(int index)
		{
			return _menuComponents[index];
		}

		public override string GetName()
		{
			return _name;
		}

		public override string GetDescription()
		{
			return _description;
		}

		public override string ToString()
		{
			return $"\n{GetName()}, {GetDescription()}" +
			       $"\n---------------------------------\n" +
			       string.Join("\n",
				       _menuComponents.Select(component => component.ToString()));
		}

		public override IEnumerator<MenuComponent> GetEnumerator()
		{
			return _menuComponents.GetEnumerator();
		}
	}

	public class NullEnumerator : IEnumerator<MenuComponent>
	{
		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public MenuComponent Current { get; }

		object IEnumerator.Current => Current;
	}
}