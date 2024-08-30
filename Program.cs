

using Constructor;

public class Program
{
	public static void Main()
	{
      Student student = new Student();

		Console.WriteLine("ParameterLess Constructor");
		
		// ParameterLess Constructor
		Student student1 = new Student();
		student1.ShowData();
		Console.WriteLine();
		Console.WriteLine("Parameterized Constructor");
		
		// Parameterized Constructor
		Student student2 = new Student(2,"Girish",10,'F');
		student2.ShowData();
		
		Console.WriteLine();
		
		Student student3 = new Student(3,"Human",5,'B');
		student3.ShowData();
		
		Console.WriteLine();
		
		Student student4 = new Student(4,"Boy",3,'G');
		student4.ShowData();

		Console.WriteLine();

		Console.WriteLine("Copy Constructor");
		// Copy Constructor
		Student student5 = new Student(student3);
		student5.ShowData();
	}
}