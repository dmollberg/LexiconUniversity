using LexiconUniversity.Models;
using System;
using System.Data.Entity;

namespace LexiconUniversity.DAL
{
    internal class UniversityContextInitializer : DropCreateDatabaseAlways<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {

            var courses = new Course[]  //Can be anonymous
            {
                new Course {CourseId= 1050, Name=".Net", Credits = 30 },
                new Course {CourseId= 1060, Name="Java", Credits = 28 }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var students = new []
            {
                new Student {FirstName = "Adam", LastName= "Andersson" },
                new Student {FirstName = "Berit",LastName= "Bosson" },
                new Student {FirstName = "Cecilia", LastName= "Carlsson" },
                new Student {FirstName = "David",LastName= "Duke" },
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var enrollments = new []
            {
                new Enrollment {StudentId = students[0].Id, Grade = Grade.A , CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-01-12")},
                new Enrollment {StudentId = students[1].Id, Grade = Grade.B, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-02-02") },
                new Enrollment {StudentId = students[0].Id, CourseId = 1060, EnrollmentDate = DateTime.Parse("2017-01-12")},
                new Enrollment {StudentId = students[1].Id,  CourseId = 1060 , EnrollmentDate = DateTime.Parse("2016-12-21")},
                new Enrollment {StudentId = students[2].Id,  CourseId = 1060 , EnrollmentDate = DateTime.Parse("2017-01-14")},
                new Enrollment {StudentId = students[3].Id, Grade = Grade.F, CourseId = 1050 , EnrollmentDate = DateTime.Today}
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();

        }
    }
}