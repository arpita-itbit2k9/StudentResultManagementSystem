using StudentResultManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Data.Services
{
    public static class FileHelper
    {
        public static void WriteCsv(string filePath, List<StudentResultCsv> records)
        {
            var sb = new StringBuilder();

            sb.AppendLine("RollNumber,StudentName,SubjectName,Marks,Total,Percentage,Grade");

            foreach (var r in records)
            {
                sb.AppendLine(
                    $"{r.RollNumber}," +
                    $"{r.StudentName}," +
                    $"{r.SubjectName}," +
                    $"{r.Marks}," +
                    $"{r.Total}," +
                    $"{r.Percentage}," +
                    $"{r.Grade}");
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
