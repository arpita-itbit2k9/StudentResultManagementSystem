using StudentResultManagementSystem.BusinessLogic.Interfaces;
using StudentResultManagementSystem.BusinessLogic.Model;
using StudentResultManagementSystem.BusinessLogic.Operation;
using System;
using System.Collections.Generic;

namespace StudentResultManagementSystem.BusinessLogic.Services
{
    public class ResultService : IResultService
    {
        private readonly ResultCalculator _calculator;

        public ResultService()
        {
            _calculator = new ResultCalculator();
        }
        public StudentResult GenerateResult(Student student, List<SubjectMarks> subjectMarks)
        {
            var totalMarks = _calculator.CalculateTotalMarks(subjectMarks);
            var obtainedMarks = _calculator.CalculateObtainedMarks(subjectMarks);
            var percentage = _calculator.CalculatePercentage(totalMarks, obtainedMarks);
            var grade = _calculator.CalculateGrade(Convert.ToInt32(percentage));

            return new StudentResult
            {
                Student = student,
                TotalMarks = totalMarks,
                ObtainedMarks = obtainedMarks,
                Percentage = percentage,
                Grade = grade
            };
        }
    }
}
