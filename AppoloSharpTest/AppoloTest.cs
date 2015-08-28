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
        }

        

        [Test]
        public void TestGetElementsWithClasses()
        {
            ClassSet cs = Appolo.GetElements<ClassSet>(Elements.CLASS);
            Assert.True(cs.ClassesArray.GetType() == typeof(Classes[]));
        }


        [Test]
        public void TestGetElementsWithCourseUnits()
        {
            var cs = Appolo.GetElements<CourseUnitSet>(Elements.COURSE_UNIT);
            Assert.True(cs.CourseUnitArray.GetType() == typeof(CourseUnit[]));
        }


        [Test]
        public void TestGetElementsWithPrograms()
        {
            var prog = Appolo.GetElements<ProgramSet>(Elements.PROGRAM);
            Assert.True(prog.ProgramArray.GetType() == typeof(Program[]));
        }

        [Test]
        public void TestGetElementsWithLectiveSemesters()
        {
            var lecSem = Appolo.GetElements<LectiveSemesterSet>(Elements.LECTIVE_SEMESTER);
            Assert.True(lecSem.LectiveSemesterArray.GetType() == typeof (LectiveSemester[]));
        }

        [Test]
        public void TestGetElementsWithTeachers()
        {
            var teachers = Appolo.GetElements<TeacherSet>(Elements.TEACHER);
            Assert.True(teachers.TeacherArray.GetType() == typeof (Teacher[]));
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

        [Test]
        public void TestGetTeacherById()
        {
            var std = Appolo.GetElementById<Teacher>(Elements.TEACHER, 1);
            Assert.True(std.Id == 1);
            Assert.True(std.Number == 1647);
            Assert.True(std.AcademicEmail.Equals("cguedes@cc.isel.ipl.pt"));
            Assert.True(std.ShortName.Equals("Carlos Guedes"));
        }

        [Test]
        public void TestGetClassById()
        {
            var cs = Appolo.GetElementById<Classes>(Elements.CLASS, 1);
            Assert.True(cs.ClassName.Equals("MI11D"));
            Assert.True(cs.Id == 1);
            Assert.True(cs.Links.GetType() == typeof(Links));
        }

        [Test]
        public void TestGetCourseUnitById()
        {
            var cs = Appolo.GetElementById<CourseUnit>(Elements.COURSE_UNIT, 1);
            Assert.True(cs.Id == 1);
            Assert.True(cs.ShortName.Equals("CSO"));
            Assert.True(cs.Name.Equals("Complementos de Sistemas Operativos"));
        }

        [Test]
        public void TestGetProgramById()
        {
            var prog = Appolo.GetElementById<Program>(Elements.PROGRAM, 1);
            Assert.True(prog.Id == 1);
            Assert.True(prog.ShortName.Equals("LEIC"));
            Assert.True(prog.Name.Equals("Licenciatura em Engenharia Informática e de Computadores"));
            Assert.True(prog.Links.GetType() == typeof(Links));
        }

        [Test]
        public void TestGetLectiveSemestersById()
        {
            var lecSem = Appolo.GetElementById<LectiveSemester>(Elements.LECTIVE_SEMESTER,  1);
            Assert.True(lecSem.LectiveSemesterId == 1);
            Assert.True(lecSem.ShortName.Equals("0910i"));
            Assert.True(lecSem.StartYear == 2009);
            Assert.True(lecSem.TermName.Equals("Fall"));
            Assert.True(lecSem.Links.GetType() == typeof(Links));
        }
    }
}
