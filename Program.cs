class Program
{
	static void Main()
	{
		Book book1 = new Book("Dune", "Frank Herbert");
		Book book2 = new Book("Frankenstein", "Mary Shelly");

		Dog dog1 = new Dog("Bosse", 4);
		Dog dog2 = new Dog("Molly", 7);

		dog1.Introduce();
		dog2.Introduce();

		Car car = new Car("Volvo", 0);
		Console.WriteLine($"{car.brand} kör i {car.speed} km/h");
		car.Accelerate();
		car.Accelerate();
		Console.WriteLine($"{car.brand} kör i {car.speed} km/h");
		car.Brake();
		car.Brake();
		Console.WriteLine($"{car.brand} kör i {car.speed} km/h");
		car.Brake();
		Console.WriteLine($"{car.brand} kör i {car.speed} km/h");
	}
}

class Book
{
	private string title;
	private string author;
	public Book(string title, string author)
	{
		this.title = MInput.CheckInput(title);
		this.author = MInput.CheckInput(author);
	}

}

class Dog
{
	public string name;
	public int age;

	public Dog(string name, int age)
	{
		this.name = MInput.CheckInput(name);
		this.age = age;
	}

	public void Introduce()
	{
		Console.WriteLine($"Jag heter {name} och är {age} år.");
	}
}

class Car
{
	public string brand;
	public int speed;

	public Car(string brand, int speed)
	{
		this.brand = MInput.CheckInput(brand);
		this.speed = speed;
	}

	public void Accelerate()
	{
		speed += 10;
	}

	public void Brake()
	{
		speed -= 10;
		if (speed <= 0)
		{
			speed = 0;
			return;
		}
	}
}