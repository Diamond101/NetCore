using NetCoreData.Interface;
using NetCoreModels;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreData.Repository
{
    public class StudentRepository : IStudent
    {
        public StudentRepository()
        {

        }

        private List<Student> StudentData()
        {
            return new List<Student>() {
                new Student
                {
                     ID = 1,
                     Surname = "Iyomere",
                     Firstname = "Samuel",
                     Othername = "Towumi",
                    MatricNo = "2100"
                },
                new Student
                {
                     ID = 2,
                     Surname = "Philip",
                     Firstname = "Diamond",
                     Othername = "",
                    MatricNo = "1234"
                },
                new Student
                {
                     ID = 3,
                     Surname = "Iyinbo",
                     Firstname = "Joshua",
                     Othername = "",
                    MatricNo = "0021"
                }
            };
        }
         
        public ICollection<Student> GetStudents() => StudentData().ToList();

        public Student GetStudentById(int id) => StudentData().FirstOrDefault(s => s.ID == id);
    }


}