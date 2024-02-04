using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GA_Practice2_AggregateAndContainment_Hongfei
{
    public class SchoolProgram
    {
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor;
        List<Student> _classRoster;

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className=className;
            _classNumber=classNumber;
            _roomNumber=roomNumber;
            _instructor=instructor;
            _classRoster = new List<Student>();

        }

        public string ClassName { get => _className; set => _className=value; }
        public string ClassNumber { get => _classNumber; set => _classNumber=value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber=value; }
        public Instructor Instructor { get => _instructor; set => _instructor=value; }
        public List<Student> ClassRoster { get => _classRoster;}

        public void AddStudent(Student student)
        {
            _classRoster.Add(student); 
        }

        public void DisplayStudents()
        {
            foreach(Student student in _classRoster)
            {
                Console.WriteLine($"{_className} {_classNumber} - {_roomNumber} - Instructor {_instructor} - Number of student {_classRoster.Count}");
                Console.WriteLine(Instructor.ToString());
                Console.WriteLine(student.ToString());
            }
        }
    }
}
