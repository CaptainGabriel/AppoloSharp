using AppoloSharp;
using AppoloSharp.Model;

namespace UnitTestProject1
{
    using NUnit.Framework;

    [TestFixture]
    public class AppoloTest
    {
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
