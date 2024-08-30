using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
	internal class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Class {  get; set; }
		public char Division { get; set; }
		public static int TotalStudent {  get; set; }

		// Static Constructor
		static Student()
		{
			TotalStudent = 4;
		}

		// ParameterLess Constructor
		public Student()
		{
			this.Id = 1;
			this.Name = "Raj";
			this.Class = 9;
			this.Division = 'A';
		}

		// Parameterized Constructor
		public Student(int id, string name, int cLass, char division)
		{
			this.Id= id;
			this.Name = name;
			this.Class= cLass;
			this.Division = division;
		}

		// Copy Constructor
		public Student(Student student)
		{
			this.Id = student.Id;
			this.Name = student.Name;
			this.Class = student.Class;
			this.Division = student.Division;
		}

		public void ShowData()
		{
			Console.WriteLine("Student Id = " + this.Id);
			Console.WriteLine("Student Name = "+ this.Name);
			Console.WriteLine("Student Class = "+ this.Class);
			Console.WriteLine("Student Division = "+ this.Division);
		}
	}
}
