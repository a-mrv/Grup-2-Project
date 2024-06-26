
using ContactDbApp.Domain.Contexts;
using ContactDbApp.Domain.Entities;
using ContactDbApp.Domain.Enums;

ContactDbAppContext context = new();

var student = new Student
{
    Id = Guid.NewGuid(),
    Name = "Ayşe Kaya",
    Grade = GradeLevel.Graduate,

};
context.Students.Add(student);

context.SaveChanges();

var findStudent=context.Students.FirstOrDefault(x=> x.Id == student.Id);

findStudent.Grade = GradeLevel.Senior;

context.SaveChanges();

context.Students.Remove(findStudent);
context.SaveChanges();