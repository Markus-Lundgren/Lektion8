class Program
{
	static void Main()
	{
		Book book1 = new("Dune", "Frank Herbert");
		Book book2 = new("Frankenstein", "Mary Shelly");

		string author = Console.ReadLine();
		string name = Console.ReadLine();

		Book book3 = new(name, author);


		Dog dog1 = new("Bosse", 4);
		Dog dog2 = new("Molly", 7);

		dog1.Introduce();
		dog2.Introduce();

		Car car = new Car("Volvo", 0);
		Console.WriteLine($"{car.Brand} kör i {car.Speed} km/h");
		car.Accelerate();
		car.Accelerate();
		Console.WriteLine($"{car.Brand} kör i {car.Speed} km/h");
		car.Brake();
		car.Brake();
		Console.WriteLine($"{car.Brand} kör i {car.Speed} km/h");
		car.Brake();
		Console.WriteLine($"{car.Brand} kör i {car.Speed} km/h");
	}
}

class Book
{
	private string _title;
	private string _author;
	public Book(string title, string author) => (_title, _author) = (MInput.CheckInput(title), MInput.CheckInput(author));
	public string Author => _author;
}

class Dog
{
	public string Name;
	public int Age;

	public Dog(string name, int age) => (Name, Age) = (name, age);

	public void Introduce()
	{
		Console.WriteLine($"Jag heter {Name} och är {Age} år.");
	}
}

class Car
{
	public string Brand;
	public int Speed;

	public Car(string brand, int speed) => (Brand, Speed) = (brand, speed);

	public void Accelerate() => Speed += 10;

	public void Brake()
	{
		Speed = (Speed <= 10) ? 0 : Speed - 10;
		if (Speed == 0)
		{
			return;
		}
	}

	class BankAccount
	{
		public string Owner;
		private int _balance;
		public BankAccount(string owner, int balance) => (Owner, _balance) = (owner, balance);

		public void Deposit(int amount)
		{
			if (_balance < 0)
			{
				Console.WriteLine("Kan ej sätta in negativa belopp!");
				amount = 0;
			}
			_balance += amount;
		}

		public int GetBalance() => _balance;
	}
}