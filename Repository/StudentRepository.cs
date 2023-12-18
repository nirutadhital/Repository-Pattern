using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Models;

namespace Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudent()
        {
            return DataSource();
        }
        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x=>x.rollNo==id).FirstOrDefault();

        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel {rollNo=1, Name="Niruta", Gender="Female", Standard=12},
                new StudentModel {rollNo=2, Name="John", Gender="Male", Standard=12},
                new StudentModel {rollNo=3, Name="Jane", Gender="Female", Standard=10},

            };
        }
        
    }
}