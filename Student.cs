using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models
{
    public class Student
    {
        #region Parameters
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        #endregion
        #region Constructor
        public Student()
        {

        }
        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dateOfBirth"></param>
        public Student(int studentId, string name, string surname, DateTime dateOfBirth)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   DateOfBirth == student.DateOfBirth;
        }

        public override int GetHashCode()
        {
            var hashCode = -480371866;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + DateOfBirth.GetHashCode();
            return hashCode;
        }
        #endregion
    }
}
