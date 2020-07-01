using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetStudent(int id);
    }

    public class StudentService : IStudentService
    {
        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { ID = 1, Name = "A", Class = "CA"},
                new Student { ID = 2, Name = "B", Class = "CB"},
                new Student { ID = 3, Name = "C", Class = "CC"}
            };
        }

        public Student GetStudent(int id)
        {
            return GetAll().Where(i => i.ID == id).FirstOrDefault();
        }
    }
}
