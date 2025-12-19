using StudentResultManagementSystem.Contracts.Interfaces;
using StudentResultManagementSystem.Contracts.Model;
using StudentResultManagementSystem.Data.Mappers;
using StudentResultManagementSystem.Data.Services;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Data.Repositories
{
    public class CsvResultRepository : IResultRepository
    { 
        public void Save(string filePath, StudentResult result, List<SubjectMarks> subjects)
        {
            var csvData=  StudentResultMapper.ToCsv(result,subjects);
            FileHelper.WriteCsv(filePath, csvData);
        }
       
    }
}
