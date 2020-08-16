using NetCoreData.Interface;
using NetCoreData.Repository;
using NetCoreModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBusiness
{
    public class StudentBusiness
    {
        private IStudent _studentRepository;

        public StudentBusiness(IStudent istudent)
        {
            _studentRepository = istudent;
        }

        public ICollection<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
    }
}
