using MauiApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Sevices
{
    public interface ITeacherService
    {
        Task<int> AddTeacher(TeacherModel teacherModel);
        Task<List<TeacherModel>> GetteacherList();
        Task<int> EditTeacher(TeacherModel teacherModel);
        Task<int> DeleteTeacher(TeacherModel teacherModel);
        Task<bool> AdminLoginAuth(string username, string password);

    }
}
