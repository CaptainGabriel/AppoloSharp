using System.Linq;
using AppoloSharp;
using AppoloSharp.Model;
using AppoloSharp.Model.interno;

namespace UnitTestProject1
{
    using NUnit.Framework;

    [TestFixture]
    public class AppoloTest
    {
        [Test]
        public void TestGetElementsWithStudents()
        {
            StudentSet stds = Appolo.GetElements<StudentSet>(Elements.STUDENT);
            Assert.True(stds.StudentArray.GetType() == typeof(Student[]));
            Assert.True(stds.StudentArray[0].ShortName.Equals("Emídio Lopes"));
            Assert.True(stds.StudentArray[0].AcademicEmail.Equals("4806@alunos.isel.pt"));
            Assert.True(stds.StudentArray[0].Number == 4806);
            Assert.True(stds.StudentArray[0].Id == 4806);
        }

        [Test]
        public void TestGetElementsWithCourseUnits()
        {
            var cs = Appolo.GetElements<CourseUnitSet>(Elements.COURSE_UNIT);
            Assert.True(cs.CourseUnitArray.GetType() == typeof(CourseUnit[]));
            Assert.True(cs.CourseUnitArray[0].Id == 1);
            Assert.True(cs.CourseUnitArray[0].ShortName.Equals("CSO"));
            Assert.True(cs.CourseUnitArray[0].FullName.Equals("Complementos de Sistemas Operativos"));
        }


        [Test]
        public void TestGetElementsWithPrograms()
        {
            var prog = Appolo.GetElements<ProgramSet>(Elements.PROGRAM);
            Assert.True(prog.ProgramArray.GetType() == typeof(Program[]));
            Assert.True(prog.ProgramArray[0].Id == 1);
            Assert.True(prog.ProgramArray[0].ShortName.Equals("LEIC"));
            Assert.True(prog.ProgramArray[0].FullName.Equals("Licenciatura em Engenharia Informática e de Computadores"));
            Assert.True(prog.ProgramArray[0].Links.GetType() == typeof(Links));
        }

        [Test]
        public void TestGetElementsWithLectiveSemesters()
        {
            var lecSem = Appolo.GetElements<LectiveSemesterSet>(Elements.LECTIVE_SEMESTER);
            Assert.True(lecSem.LectiveSemesterArray.GetType() == typeof(LectiveSemester[]));
            Assert.True(lecSem.LectiveSemesterArray[0].LectiveSemesterId == 1);
            Assert.True(lecSem.LectiveSemesterArray[0].Links.GetType() == typeof(Links));
        }


        [Test]
        public void TestGetStudentByIdString()
        {
            var std = Appolo.GetElementById<Student>(Elements.STUDENT, "38209");
            Assert.True(std.Id == 38209);
            Assert.True(std.Number == 38209);
            Assert.True(std.AcademicEmail.Equals("38209@alunos.isel.pt"));
            Assert.True(std.Name.Equals("Pedro Gabriel Pita de Almeida"));
        }

        [Test]
        public void TestGetStudentByIdInt()
        {
            var std = Appolo.GetElementById<Student>(Elements.STUDENT, 38209);
            Assert.True(std.Id == 38209);
            Assert.True(std.Number == 38209);
            Assert.True(std.AcademicEmail.Equals("38209@alunos.isel.pt"));
            Assert.True(std.Name.Equals("Pedro Gabriel Pita de Almeida"));
        }
    }
}
