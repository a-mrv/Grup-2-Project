
using EFCore.Console.Contexts;
using EFCore.Console.Entities;
using EFCore.Console;

AppDbContext appDbContext = new();

var student1 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe",

};

appDbContext.Students.Add(student1);

appDbContext.SaveChanges();

var students = appDbContext.Students.ToList();

foreach (var student in students)

{
    Console.WriteLine($"Student : {student.FirstName} {student.LastName}");
}