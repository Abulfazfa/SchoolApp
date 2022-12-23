using Practise23._12.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise23._12.Domain.Services.Interfaces
{
    internal interface IClass
    {
        void AddStudent(Student student, string className, string schoolName);
        void ChangeStudentClass(string studentName, string className);
        void DeleteStudent(Student student);
        void FindStudent(Student student);
    }
}
