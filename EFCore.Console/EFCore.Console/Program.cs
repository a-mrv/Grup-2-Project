
using EFCore.Console.Contexts;
using EFCore.Console.Entities;
using EFCore.Console;
using Microsoft.EntityFrameworkCore;

AppDbContext appDbContext = new();

var student1 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doel",

};
var student2 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe",

};

dbContext.Students.Add(student1);
dbContext.Students.Add(student2);


dbContext.SaveChanges();

var students = dbContext.Students.ToList();

foreach (var student in students)

{
    Console.WriteLine($"Student : {student.FirstName} {student.LastName}");
}