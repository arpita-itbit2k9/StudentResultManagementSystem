using NUnit.Framework;
using StudentResultManagementSystem.Contracts.Model;
using StudentResultManagementSystem.BusinessLogic.Operation;
using System;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Tests
{
    [TestFixture]
    public class StudentResultTests
    {
        private Student student;
        private List<SubjectMarks> subjectsMarks;
        private ResultCalculator resultCalculator;

        [SetUp]
        public void SetUp()
        {
            CreateMockData();
        }

        [Test]
        public void CalculateTotalMarks_WhenValidMarksProvided_ReturnsCorrectTotal()
        {

            var totalMarks = resultCalculator.CalculateTotalMarks(subjectsMarks);

            Assert.That(totalMarks, Is.EqualTo(300));
        }

        [Test]
        public void CalculateObtainedMarks_WhenValidMarksProvided_ReturnsCorrectObtainedMarks()
        {
           
            var obtainedMarks = resultCalculator.CalculateObtainedMarks(subjectsMarks);

            Assert.That(obtainedMarks, Is.EqualTo(270));
        }

        [Test]
        public void CalculatePercentage_WhenValidMarksProvided_ReturnsCorrectPercentage()
        {
           
            var percentage = resultCalculator.CalculatePercentage(300,270);

            Assert.That(percentage.ToString(), Is.EqualTo("90"));
        }

        [Test]
        public void CalculateGrade_WhenValidMarksProvided_ReturnsCorrectGrade()
        {
            var grade = resultCalculator.CalculateGrade(90);

            Assert.That(grade, Is.EqualTo("A+"));
        }


        private void CreateMockData()
        {
            subjectsMarks = new List<SubjectMarks>
                {
                    new SubjectMarks { SubjectId = 1, SubjectName="Maths", MinMarks = 33, MaxMarks = 100 ,Marks = 85 },
                    new SubjectMarks { SubjectId = 2, SubjectName="Science", MinMarks = 33, MaxMarks = 100 ,Marks = 90 },
                    new SubjectMarks { SubjectId = 3, SubjectName="English", MinMarks = 33, MaxMarks = 100 ,Marks = 95 },

                };
            student = new Student
            {
                StudentId = 1,
                RollNumber = 101,
                Name = "John Doe",
                SubjectsMarks = subjectsMarks,
            };



            resultCalculator = new ResultCalculator();
        }

    }
}
