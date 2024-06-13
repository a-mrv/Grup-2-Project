using MextFSBeginner.Entities.BaseClasses;
using MextFSBeginner.Entities.Enums;
using MextFSBeginner.Entities;
using Entities;




var teacher = new Teacher()
{
    FirstName = "Alper",
    LastName = "Tunga",
    IdentityNumber = "123456789052342345",
};

var student = new Student()
{
    FirstName = "Sena",
    LastName = "Tasci",
    No = 100,
    IdentityNumber = "52367342567890",
};

var parent = new Parent()
{
    FirstName = "Seyda Nur",
    LastName = "Tasci",
    IdentityNumber = "1234567890"
};

var securtyEmployee = new Employee()
{
    FirstName = "Mehmet",
    LastName = "Tasci",
    Type = EmployeeType.Security,
    IdentityNumber = "4658373534243"
};

var cleanerEmployee = new Employee()
{
    FirstName = "Francheska",
    LastName = "Tunga",
    Type = EmployeeType.Cleaner
};

List<object> people = new List<object>();

people.Add(2.29d); // double

people.Add(21.39d); // double

people.Add(teacher); // Teacher

people.Add(teacher); // Teacher

people.Add(student); // Student

people.Add(student); // Student


people.Add(teacher); // Teacher

people.Add(teacher); // Teacher

people.Add(2.29d); // double

people.Add(student); // Student

people.Add(9399.559M); // decimal

people.Add(125); // int32


people.Add(parent); // parent

people.Add(305); // int32

people.Add(999.9999M); // decimal

people.Add(securtyEmployee); // Employee

people.Add(7255125); // int32

people.Add(cleanerEmployee); // Employee

people.Add("rtsdfsdfklnsdfsdfsfd"); // string


//Console.WriteLine("Balo Katilimcilari Listesi:");
int teacherSayac = 0;
int studentSayac = 0;
int parentSayac = 0;
int doubleSayac = 0;
int decimalSayac = 0;
foreach (var person in people)
{
    if (person is Teacher)
    {
        //var personBase = person as PersonBase;
        teacherSayac++;
    }
    if (person is Student)
    {
        studentSayac++;
    }
    if (person is Parent)
    {
        parentSayac++;
    }
    if (person is double)
    {
        // 
        doubleSayac++;
    }
    if (person is decimal)
    {
        decimalSayac++;
    }
}
Console.WriteLine($"Teacher {teacherSayac} tane bulundu.");
Console.WriteLine($"Student {studentSayac} tane bulundu.");
Console.WriteLine($"Parent {parentSayac} tane bulundu.");
Console.WriteLine($"double {doubleSayac} tane bulundu.");
Console.WriteLine($"decimal {decimalSayac} tane bulundu.");






//foreach (var person in people)
//{
//    if (person is PersonBase)
//    {
//        var personBase = person as PersonBase;

//        Console.WriteLine(personBase.FullInfo);
//    }
//    else
//    {
//        Console.WriteLine("Gelen deger gecerli degil. Baloya katilim saglanmayacaktir.");
//    }
//}
// double => 3 tane bulundu.
// Empoyee => 2 tane bulundu.
// string => 1 tane bulundu.
//Console.ReadLine();