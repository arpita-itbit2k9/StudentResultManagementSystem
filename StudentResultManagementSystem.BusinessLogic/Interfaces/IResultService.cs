using StudentResultManagementSystem.BusinessLogic.Model;
using System.Collections.Generic;

namespace StudentResultManagementSystem.BusinessLogic.Interfaces
{
    public interface IResultService
    {
        StudentResult GenerateResult(Student student, List<SubjectMarks> subjectMarks);
    }
}
