using NetCoreModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreData.Interface
{
    public interface IStudent
    {
        ICollection<Student> GetStudents();
        Student GetStudentById(int id);
    }
}
