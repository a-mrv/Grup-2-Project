using EducationInterfaces.University;

Ankara ankara = new ();
ankara.Midterm1 = 35;
ankara.Midterm2 = 70;
ankara.Final = 80;

double ankaraResult = ankara.ExamResult();

Hacettepe hacettepe = new();
hacettepe.Quiz1 = 30;
hacettepe.Quiz2 = 40;
hacettepe.Midterm1 = 55;
hacettepe.Midterm2 = 60;
hacettepe.Final = 80;

double hacettepeResult = hacettepe.ExamResult();

Odtü odtü= new();

odtü.Quiz1 = 80;
odtü.Quiz2 = 75;
odtü.Midterm1 = 85;
odtü.Final = 90;
double odtüResult = odtü.ExamResult();

Console.WriteLine(ankaraResult);
Console.WriteLine(hacettepeResult);
Console.WriteLine(odtüResult);

