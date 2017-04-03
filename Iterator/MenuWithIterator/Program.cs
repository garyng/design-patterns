using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuWithIterator
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
			new Waitress(new PancakeHouseMenu(), new DinerMenu()).PrintMenu();
		}
	}

	public class Waitress
	{
		private readonly IMenu _pancakeHouseMenu;
		private readonly IMenu _dinerMenu;

		public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
		{
			_pancakeHouseMenu = pancakeHouseMenu;
			_dinerMenu = dinerMenu;
		}

		public void PrintMenu()
		{
			IIterator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
			IIterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();

			Console.WriteLine("--- Breakfast ---");
			printMenu(pancakeIterator);
			Console.WriteLine();
			Console.WriteLine("--- Lunch ---");
			printMenu(dinerIterator);
		}

		private void printMenu(IIterator<MenuItem> iterator)
		{
			while (iterator.HasNext())
			{
				Console.WriteLine(iterator.Next());
			}
		}
	}

	public interface IIterator<out T>
	{
		bool HasNext();
		T Next();
	}

	public class DinerMenu : IMenu
	{
		private const int MAX_ITEMS = 6;
		private MenuItem[] _menuItems;
		private int _numberOfItems = 0;

		public DinerMenu()
		{
			_menuItems = new MenuItem[MAX_ITEMS];

			AddItem("Vegetarian BLT",
				"(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
			AddItem("BLT",
				"Bacon with lettuce & tomato on whole wheat", false, 2.99);
			AddItem("Soup of the day",
				"Soup of the day, with a side of potato salad", false, 3.29);
			AddItem("Hotdog",
				"A hot dog, with saurkraut, relish, onions, topped with cheese",
				false, 3.05);
			AddItem("Steamed Veggies and Brown Rice",
				"Steamed vegetables over brown rice", true, 3.99);
			AddItem("Pasta",
				"Spaghetti with Marinara Sauce, and a slice of sourdough bread",
				true, 3.89);
		}

		public void AddItem(string name, string description, bool isVegetarian, double price)
		{
			MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
			if (_numberOfItems >= MAX_ITEMS)
			{
				Console.WriteLine("Menu is full!");
			}
			else
			{
				_menuItems[_numberOfItems++] = menuItem;
			}
		}

		public MenuItem[] GetMenuItems()
		{
			return _menuItems;
		}

		public IIterator<MenuItem> CreateIterator()
		{
			return new DinerMenuIterator(_menuItems);
		}
	}

	public class DinerMenuIterator : IIterator<MenuItem>
	{
		private readonly MenuItem[] _menuItems;
		private int _position = 0;

		public DinerMenuIterator(MenuItem[] menuItems)
		{
			_menuItems = menuItems;
		}

		public bool HasNext()
		{
			return _position < _menuItems.Length && _menuItems[_position] != null;
		}

		public MenuItem Next()
		{
			return _menuItems[_position++];
		}
	}

	public interface IMenu
	{
		IIterator<MenuItem> CreateIterator();
	}

	public class PancakeHouseMenu : IMenu
	{
		private ArrayList _menuItems;

		public PancakeHouseMenu()
		{
			_menuItems = new ArrayList();

			AddItem("K&B's Pancake Breakfast",
				"Pancakes with scrambled eggs, and toast",
				true,
				2.99);
			AddItem("Regular Pancake Breakfast",
				"Pancakes with fried eggs, sausage",
				false,
				2.99);
			AddItem("Blueberry Pancakes",
				"Pancakes made with fresh blueberries, and blueberry syrup",
				true,
				3.49);
			AddItem("Waffles",
				"Waffles, with your choice of blueberries or strawberries",
				true,
				3.59);
		}

		public void AddItem(string name, string description, bool isVegetarian, double price)
		{
			_menuItems.Add(new MenuItem(name, description, isVegetarian, price));
		}

		public ArrayList GetMenuItems()
		{
			return _menuItems;
		}

		public IIterator<MenuItem> CreateIterator()
		{
			return new PancakeHouseIterator(_menuItems);
		}
	}

	public class PancakeHouseIterator : IIterator<MenuItem>
	{
		private readonly ArrayList _menuItems;
		private int _position = 0;

		public PancakeHouseIterator(ArrayList menuItems)
		{
			_menuItems = menuItems;
		}

		public bool HasNext()
		{
			return _position < _menuItems.Count && _menuItems[_position] != null;
		}

		public MenuItem Next()
		{
			return (MenuItem) _menuItems[_position++];
		}
	}

	public class MenuItem
	{
		public string Name { get; }
		public string Description { get; }
		public bool IsVegetarian { get; }
		public double Price { get; }

		public MenuItem(string name, string description, bool isVegetarian, double price)
		{
			Name = name;
			Description = description;
			IsVegetarian = isVegetarian;
			Price = price;
		}

		public override string ToString()
		{
			return $"{Name}, {Price} -- {Description}";
		}
	}
}