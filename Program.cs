
using Azure;
using Egzas1220;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using var dbContext = new Context();


/*1.Sukurti departamentą ir į jį pridėti studentus, paskaitas(papildomi points jei pridedamos paskaitos jau egzistuojančios duomenų bazėje).
4. Sukurti studentą, jį pridėti prie egzistuojančio departamento ir priskirti jam egzistuojančias paskaitas.
5. Perkelti studentą į kitą departamentą(bonus points jei pakeičiamos ir jo paskaitos).
6.Atvaizduoti visus departamento studentus.
7. Atvaizduoti visas departamento paskaitas.
8. Atvaizduoti visas paskaitas pagal studentą.*/

/*var student1 = new Student("Studentas1", new DateTime(1970 - 01 - 01));
var student2 = new Student("Studentas2", new DateTime(1980 - 01 - 01));
var student3 = new Student("Studentas3", new DateTime(1990 - 01 - 01));
var student4 = new Student("Studentas4", new DateTime(2000 - 01 - 01));

var department1 = new Department("Maths", "computation skils");
var department2 = new Department("Literature", "interpretation skils");
var department3 = new Department("Technology", "IoT");
var department4 = new Department("Sports", "healthy life style");

department1.Students.Add(student1);
department2.Students.Add(student2);
department3.Students.Add(student3);
department4.Students.Add(student4);

dbContext.AddRange(
 new Lecture { Code = "pas1", Name = "Paskaita1", Departments = new List<Department> { department1 } },
 new Lecture { Code = "pas2", Name = "Paskaita2", Departments = new List<Department> { department2 } },
 new Lecture { Code = "pas3", Name = "Paskaita3", Departments = new List<Department> { department3 } },
 new Lecture { Code = "pas4", Name = "Paskaita4", Departments = new List<Department> { department4 } }
);

dbContext.SaveChanges();*/


//2.Pridėti studentus / paskaitas į jau egzistuojantį departamentą.
//3.Sukurti paskaitą ir ją priskirti prie departamento.
/*var student5 = new Student("Studentas5", new DateTime(2000 - 01 - 01));

var returnedDepFromDB = dbContext.Department.Where(x => x.Name == "Maths").Include(x => x.Students).First();
returnedDepFromDB.Students.Add(student5);

dbContext.AddRange(
 new Lecture { Code = "pas5", Name = "Paskaita5", Departments = new List<Department> { returnedDepFromDB } },
 new Lecture { Code = "pas6", Name = "Paskaita6", Departments = new List<Department> { returnedDepFromDB } }
);

dbContext.SaveChanges();*/


//4.Sukurti studentą, jį pridėti prie egzistuojančio departamento ir priskirti jam egzistuojančias paskaitas.
var student6 = new Student("Studentas6", new DateTime(1999 - 01 - 01));
var returnedDepFromDB = dbContext.Department.Where(x => x.Name == "Maths").Include(x => x.Lectures).First();

returnedDepFromDB.Students.Add(student6);

dbContext.SaveChanges();

//5. Perkelti studentą į kitą departamentą(bonus points jei pakeičiamos ir jo paskaitos).



//6.Atvaizduoti visus departamento studentus.





//7.Atvaizduoti visas departamento paskaitas.
var departmentLectures = dbContext.Department.Include(x => x.Lectures).ToList();

foreach (var department in departmentLectures)
{
       foreach (var lecture in department.Lectures)
    {
        Console.WriteLine($"Departamento {department.Name} paskaitos {lecture.Name}");
    }
    
}

//8. Atvaizduoti visas paskaitas pagal studentą.*/
var studentsList = dbContext.Students.Include(x => x.Department).ThenInclude(x => x.Lectures).ToList();

/*foreach (var student in studentsList)
{
    foreach (var lecture in Lectures)
    {
        Console.WriteLine($"Departamento {student.Name} paskaitos {lecture.Name}");
    }
}*/