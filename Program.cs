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
	}
}

class Book
{
	private string title;
	private string author;
	public Book(string bookTitle, string bookAuthor)
	{
		title = MInput.CheckInput(bookTitle);
		author = MInput.CheckInput(bookAuthor);
	}

}

class Dog
{
	public string name;
	public int age;

	public Dog(string name, int age)
	{

	}

	public void Introduce()
	{
		Console.WriteLine($"Jag heter {name} och är {age} år.");
	}
}