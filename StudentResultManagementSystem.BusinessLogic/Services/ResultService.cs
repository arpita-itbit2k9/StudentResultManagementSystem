using StudentResultManagementSystem.Contracts.Interfaces;
using StudentResultManagementSystem.Contracts.Model;
using StudentResultManagementSystem.BusinessLogic.Operation;
using System;
using System.Collections.Generic;

namespace StudentResultManagementSystem.BusinessLogic.Services
{
    public class ResultService : IResultService
    {
        private readonly ResultCalculator _calculator;
        private StudentResult _studentResult;
        private readonly IResultRepository _resultRepository;


        public ResultService(IResultRepository resultRepository)
        {
            _calculator = new ResultCalculator();
            _resultRepository = resultRepository ?? throw new ArgumentNullException(nameof(resultRepository));
        }
        public StudentResult GenerateResult(Student student, List<SubjectMarks> subjectMarks)
        {
            var totalMarks = _calculator.CalculateTotalMarks(subjectMarks);
            var obtainedMarks = _calculator.CalculateObtainedMarks(subjectMarks);
            var percentage = _calculator.CalculatePercentage(totalMarks, obtainedMarks);
            var grade = _calculator.CalculateGrade(Convert.ToInt32(percentage));

            _studentResult = new StudentResult
            {
                Student = student,
                TotalMarks = totalMarks,
                ObtainedMarks = obtainedMarks,
                Percentage = percentage,
                Grade = grade
            };
            return _studentResult;
        }

        public bool SaveResult(string filePath, StudentResult studentResult, List<SubjectMarks> subjectMarksList)
        {
            if (studentResult == null)
                throw new ArgumentNullException(nameof(studentResult));

            _resultRepository.Save(filePath, studentResult, subjectMarksList);
            return true;
        }
    }
}
