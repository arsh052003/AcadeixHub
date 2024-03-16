using MauiApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Sevices
{
    public interface IStudentService
    {
        Task<int> AddStudent(StudentModel studentModel);
        Task<List<StudentModel>> GetStudentList();
        Task<int> EditStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
    }
}
