using NUnit.Framework;
using StudentResultManagementSystem.BusinessLogic.Model;
using StudentResultManagementSystem.BusinessLogic.Operation;
using System;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Tests
{
    [TestFixture]
    public class StudentResultTests
    {
        private Student student;
        private StudentResult studentResult;

        [SetUp]
        public void SetUp()
        {
            CreateMockData();
        }

        [Test]
        public void CalculateTotalMarks_WhenValidMarksProvided_ReturnsCorrectTotal()
        {

            var totalMarks = studentResult.CalculateTotalMarks();

            Assert.That(totalMarks, Is.EqualTo(300));
        }

        [Test]
        public void CalculateObtainedMarks_WhenValidMarksProvided_ReturnsCorrectObtainedMarks()
        {
           
            var obtainedMarks = studentResult.CalculateObtainedMarks();

            Assert.That(obtainedMarks, Is.EqualTo(270));
        }

        [Test]
        public void CalculatePercentage_WhenValidMarksProvided_ReturnsCorrectPercentage()
        {
           
            var percentage = studentResult.CalculatePercentage(300,270);

            Assert.That(percentage.ToString(), Is.EqualTo("90"));
        }

        [Test]
        public void CalculateGrade_WhenValidMarksProvided_ReturnsCorrectGrade()
        {
            var result = new StudentResult { Student = student };
            var grade = result.CalculateGrade(90);

            Assert.That(grade, Is.EqualTo("A+"));
        }


        private void CreateMockData()
        {
             student = new Student
            {
                StudentId = 1,
                RollNumber = 101,
                Name = "John Doe",
                Subjects = new List<Subject>
                {
                    new Subject { SubjectId = 1, SubjectName="Maths", MinMarks = 33, MaxMarks = 100 ,Marks = 85 },
                    new Subject { SubjectId = 2, SubjectName="Science", MinMarks = 33, MaxMarks = 100 ,Marks = 90 },
                    new Subject { SubjectId = 3, SubjectName="English", MinMarks = 33, MaxMarks = 100 ,Marks = 95 },

                }
            };

            studentResult = new StudentResult { Student = student };
        }

    }
}
