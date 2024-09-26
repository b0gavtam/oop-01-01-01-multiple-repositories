// See https://aka.ms/new-console-template for more information
using SchoolClassManagmentProject.Models.AppException;
using SchoolClassManagmentProject.Models.Entities;
using SchoolClassManagmentProject.Repos;

SchoolClass schoolClass9a = new SchoolClass(9, 'a', 12);
SchoolClass schoolClass9b = new SchoolClass(9, 'b', 13);
SchoolClass schoolClass10a = new SchoolClass(10, 'a', 12);
SchoolClass schoolClass10b = new SchoolClass(10, 'b', 12);

SchoolClass schoolClass12a = new SchoolClass(12, 'a', 12);
SchoolClass schoolClass12b = new SchoolClass(12, 'b', 12);

SchoolClass schoolClass13a = new SchoolClass(13, 'a', 13);
SchoolClass schoolClass13b = new SchoolClass(13, 'b', 13);


Student student1 = new Student("Nagy", "Jani", true, new DateTime(2006, 12, 22), null, "+36301357656");
Console.WriteLine(student1.ToString());
Console.WriteLine(student1.HasEmail);
Console.WriteLine(student1.HasPhone);
Console.WriteLine(student1.GetAge());
SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
schoolClassRepo.Add(schoolClass9a);
schoolClassRepo.Add(schoolClass9b);
schoolClassRepo.Add(schoolClass10a);
schoolClassRepo.Add(schoolClass10b);
schoolClassRepo.Add(schoolClass12a);
schoolClassRepo.Add(schoolClass12b);
schoolClassRepo.Add(schoolClass13a);
schoolClassRepo.Add(schoolClass13b);
Console.WriteLine("Végzős osztályok:");
List<SchoolClass> graduateClasses = schoolClassRepo.GetGraduateClasses();
foreach (SchoolClass graduateClass in graduateClasses)
{
    Console.WriteLine(graduateClass.ToString());
}