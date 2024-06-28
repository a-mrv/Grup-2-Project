
using Microsoft.Extensions.Caching.Memory;
using StudentsApp.Domain.Entities;
using StudentsApp.Domain.Enums;
using StudentsApp.Infrastructure.Persistence.Contexts;

AppDbContext context = new();

Student student = new Student()
{
    Id = Guid.NewGuid(),
    Name = "Ayşe Ak",
    Grade =GradeLevel.Higher,
};
context.Students.Add(student);


Lecture lecture = new()
{
    Id = Guid.NewGuid(),
    Title = "A",
    Type = LectureType.Online,
};
context.Lectures.Add(lecture);



MemoryCache cache = new(new MemoryCacheOptions()
{
ExpirationScanFrequency=TimeSpan.FromDays(1),
});

var lecturesFromCache = cache.Get<List<Lecture>>("LectureCacheKey");

List<Lecture> lectures = null;

if (lecturesFromCache == null)
{
     lectures = context.Lectures.ToList();
     cache.Set("LecturesCacheKey", lectures);
    

}


Console.WriteLine($"öğrenci ismi: {student.Name} - sınıfı: {student.Grade}");
Console.WriteLine($"başlık: {lecture.Title} - tipi:{lecture.Type}");

context.SaveChanges();