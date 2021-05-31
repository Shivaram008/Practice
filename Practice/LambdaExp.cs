using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
	class Dog
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
	class LambdaExp
	{

		public static void Display<T>(List<T> a)
		{
			foreach(var i in a)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}
		public static void Main(String[] args)
		{
			List<int> a = new List<int>();
			for(int i=1;i<6;i++)
			{
				a.Add(i);
			}
			Display<int>(a);

			var k = a.FindAll(x => x % 2 == 0);
			foreach (var i in k)
			{
				System.Console.Write($"{i} ");
			}
			a.Clear();
			Display(a);
			List<Dog> dogs = new List<Dog>() {
				new Dog { Name = "Rex", Age = 4 },
				new Dog { Name = "Sean", Age = 0 },
				new Dog { Name = "Stacy", Age = 3 }
			};
			var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
			foreach (var item in newDogsList)
			{
				Console.WriteLine(item);
			}

			var sortedDogs = dogs.OrderByDescending(x => x.Age);
			foreach (var dog in sortedDogs)
			{
				Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
			}
			Console.ReadKey();
		}
	}
}
