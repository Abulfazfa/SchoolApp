
using Practise23._12.Models.BaseEntity;

Class @class = new();
Student student1 = new() { Name = "A" };
Student student2 = new() { Name = "B" };
Student student3 = new() { Name = "C" };
Class.classStudent[0] = student1;
Class.classStudent[1] = student2;
Class.classStudent[2] = student3;
@class.DeleteStudent(student1.Name);
foreach (var item in Class.classStudent)
{
    Console.WriteLine(item);
}
