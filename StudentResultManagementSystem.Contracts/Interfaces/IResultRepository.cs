

using StudentResultManagementSystem.Contracts.Model;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Contracts.Interfaces
{
    public interface IResultRepository
    {
        void Save(string filePath, StudentResult result, List<SubjectMarks> subjects);
    }
}
