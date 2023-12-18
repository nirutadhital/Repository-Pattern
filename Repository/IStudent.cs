using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Models;

namespace Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudent();
        StudentModel getStudentById(int id);
    }
}