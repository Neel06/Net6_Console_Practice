using AdaptersServiceTest;
using AdaptersServiceTest.Models;


List<Item> items = new()
{
	new Item(){name = "A", percentage= 1},
	new Item(){name = "B", percentage= 65},
	new Item(){name = "C", percentage= 15},
	new Item(){name = "D", percentage= 19},
};


Item generatedItem = RandomNumberBasedOnPercentage.SelectItem(items);

while (true)
{
    Console.WriteLine("#--> Press 1 to Generate Method \n #--> Press 9 to Exit");
	int a = Convert.ToInt16(Console.ReadLine());

	switch (a)
    {
		case 1: var temp = RandomNumberBasedOnPercentage.SelectItem(items);
			Console.WriteLine("\n"+temp.name+" --> " + temp.percentage+"\n");
			break;

		case 9: return;

		default: Console.WriteLine("##--> Press 1 to Generate Method \n ##--> Press 9 to Exit");
			break;
	}
	
	
}

Console.WriteLine(generatedItem.name + generatedItem.percentage);



//string[] UsersList = { "Anoz", "Neel", "Prince", "Ronak", "Dhaval", "Deep" };
//List<Student> StudentList = new(){
//            new Student (){ Id= 3,Name= "Neel", Age=24,Department = "IT" },
//            new Student (){ Id= 2,Name= "Ronak", Age=22,Department = "CSE" },
//            new Student (){ Id= 1,Name= "Anoz", Age=25,Department = "MECH" },
//            new Student (){ Id= 12,Name= "Dhaval", Age=23,Department = "ELECTRICAL" },
//            new Student (){ Id= 4,Name= "Prince", Age=24,Department = "CIVIL" },
//            new Student (){ Id= 15,Name= "Deep", Age=21,Department = "PLASTIC" },
//            new Student (){ Id= 22,Name= "Raj", Age=22,Department = "TEXTILE" },
//            new Student (){ Id= 6,Name= "Miral", Age=24,Department = "ICE" },
//        };


//LinqExample linqExample = new();
//linqExample.LinqInQueryForm(UsersList);
//linqExample.LinqInLambdaForm(StudentList);



//var schools = new[] {
//			new School(){ students = new [] { new student(){ Name="Bob"}, new student(){ Name="Jack"} }},
//			new School(){ students = new [] { new student(){ Name="Jim"}, new student(){ Name="John"} }}
//		};
//var allStudents = schools.SelectMany(s => s.students);
//var test = schools.Select(a => a.students);

//var temp = test.Select(a => a);

//Console.WriteLine("Temp: " + temp);

//foreach (var student in allStudents)
//{
//	Console.WriteLine(student.Name);
//}
//Console.WriteLine("");
//foreach (var item in temp)
//{
//	foreach (var students in item)
//    {
//            Console.WriteLine("Student Name: "+students.Name);
//    }
//}

//InterfaceInsideClassExample interfaceExample = new(); //Date: 17-06-2022
//interfaceExample.SetUserDetails("Neel", "Nargol");
//interfaceExample.GetUserDetails();


//AsyncExample asyncExample = new AsyncExample();   //Date:?
//Task<int> result = asyncExample.add();
//Console.WriteLine(result.Result);

//Console.WriteLine("Hello, World!");
//DemoClass a = new DemoClass(name:"Anoz",description:"Hello",id:5);
//DemoClass b = new DemoClass(description:"Yo",id:10);
//a.GreetUser();
//b.GreetUser();

//YieldExample yieldExample = new();

//foreach (var item in YieldExample.fibonacci(10))
//{
//    Console.WriteLine(item);
//}

class School
{
	public student[] students { get; set; }
}

class student
{
	public string Name { get; set; }
}
