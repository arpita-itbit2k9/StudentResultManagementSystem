using StudentResultManagementSystem.Contracts.Model;
using StudentResultManagementSystem.Data.DTO;
using System.Collections.Generic;

namespace StudentResultManagementSystem.Data.Mappers
{
    public static class StudentResultMapper
    {
        public static List<StudentResultCsv> ToCsv(StudentResult result, List<SubjectMarks> subjectsMarks)
        {
            var csvList = new List<StudentResultCsv>();

            foreach (var mark in subjectsMarks)
            {
                csvList.Add(new StudentResultCsv
                {
                    RollNumber = result.Student.RollNumber,
                    StudentName = result.Student.Name,
                    SubjectName = mark.SubjectName,
                    Marks = mark.Marks,
                    Total = result.TotalMarks,
                    Percentage = result.Percentage,
                    Grade = result.Grade
                });
            }

            return csvList;
        }
    }



}
