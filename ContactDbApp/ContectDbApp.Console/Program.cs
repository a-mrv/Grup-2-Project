
using ContactDbApp.Domain;
using ContactDbApp.Domain.Contexts;
using ContactDbApp.Domain.Entities;
using ContactDbApp.Domain.Enums;
using System.Net.Http.Headers;


ContactDbAppContext context = new();

//Student student1 = new()

//{ Id = Guid.NewGuid(),
//    Name = "Ayşe Kaya",
//    Grade = GradeLevel.Graduate,
//};
//Student student2 = new()

//{
//    Id = Guid.NewGuid(),
//    Name = "Elif Ay",
//    Grade = GradeLevel.Senior,
//};
//context.Students.Add(student2);

//context.SaveChanges();

//var students = context.Students.ToList();

//foreach (var student in students)
//{
//    Console.WriteLine($"{student.Name}) - {student.Grade}");
//}

string seçim = "";

while (seçim != "3")
{
    Console.WriteLine("1 - Ekle");
    Console.WriteLine("2 - Göster");
    Console.WriteLine("3 - Çıkış");
    Console.WriteLine("Seçiminizi yapınız.");

    seçim = Console.ReadLine();

    switch (seçim)
    {
        case "1":
            Console.WriteLine("Öğrenci ismini giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Öğrenci sınıfını giriniz.");
            string grade = Console.ReadLine();

            GradeLevel gradeLevel = GradeLevel.Junior;

            if(grade== "Junior")
            {
                gradeLevel = GradeLevel.Junior;
            }
           

            if (grade == "Senior")
            {
                gradeLevel = GradeLevel.Senior;
            }
            
            if (grade == "Freshman")
            {
                gradeLevel = GradeLevel.Freshman;
            }
            if (grade == "Sophomore")
            {
                gradeLevel = GradeLevel.Sophomore;
            }
            if (grade == "Graduate")
            {
                gradeLevel = GradeLevel.Graduate;
            }

            Student student = new()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Grade = gradeLevel,
            };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine($"Öğrenci ismi:{name} - sınıfı: {grade}");
            break;

        case "2":
            
            var students = context.Students.ToList();

            foreach (var student1 in students)
            {
                
                Console.WriteLine($"{student1.Name}) - {student1.Grade}");
            }
            break;
        case "3":
            Console.WriteLine("Çıkış yapılıyor.");
            break;
        default:
            Console.WriteLine("Tekrar deneyin.");
            break;

    }
}
