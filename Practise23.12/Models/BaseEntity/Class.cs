using Practise23._12.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise23._12.Models.BaseEntity
{
    internal class Class 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxStudentCount { get; set; } = 2;
        public static Student[] classStudent;

        static Class()
        {
            classStudent = new Student[10];
        }

        public void AddStudent(Student student, string className, string schoolName)
        {
            Array.Resize(ref classStudent, classStudent.Length + 1);
            classStudent[classStudent.Length - 1] = student;
        }

        public void ChangeStudentClass(string studentName, string className)
        {
            DeleteStudent(studentName);
            //studenti diger sinife elave et
            
        }

        public void DeleteStudent(string studentName)
        {
            Student? findedStudent = Array.Find(classStudent, s => s.Name == studentName);
            int index = Array.IndexOf(classStudent, findedStudent);
            classStudent[index] = classStudent[classStudent.Length - 1];
            Array.Resize(ref classStudent, classStudent.Length - 2);

        }

        public void FindStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
