using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void IsGradeAdded()
        {
            var newGrade = 4;
            var gradeBook = new GradeBook();
            gradeBook.AddGrade(newGrade);

            Assert.AreEqual(true, gradeBook.grades.Contains(newGrade));
        }
    }
}
