using StudentResultManagementSystem.Contracts.Model;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Contracts.Interfaces
{
    public interface IResultService
    {
        StudentResult GenerateResult(Student student, List<SubjectMarks> subjectMarks);
        bool SaveResult(string filePath, StudentResult result, List<SubjectMarks> subjects);
    }
}
