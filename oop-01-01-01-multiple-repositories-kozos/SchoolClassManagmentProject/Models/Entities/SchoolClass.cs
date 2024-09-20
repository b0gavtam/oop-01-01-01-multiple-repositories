using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClassManagmentProject.Models.AppException;
namespace SchoolClassManagmentProject.Models.Entities
{
    public class SchoolClass
    {
        private byte _grade;
        private char _gradeLetter;
        private byte _lastGrade;


        public SchoolClass() { 
            Grade = byte.MinValue;
            GradeLetter = char.MinValue;
        }
        public SchoolClass(byte grade, char gradeLetter, byte lastGrade = 0)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
            _lastGrade = lastGrade;
        }
        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _grade; set => _lastGrade = value; }
        //public string Name { get => $"{grade}.{gradeLetter}"; }

        public string Name => $"{_grade}.{_gradeLetter}";
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduating => _grade == _lastGrade;
        public bool IsActive => !HasGraduated;

        public void SetLastGrade(byte newGrade)
        {
            if (newGrade > _grade)
            {
                _lastGrade = newGrade;
                
            }
            else
            {
                throw new LastGradeModificationErrorException($"{nameof(SchoolClass)} osztályban, {nameof(SetLastGrade)} metódusban paraméterhiba történt.",nameof(Grade), null);
            }
        }
        public void AdvanceGrade() {
            if (IsActive)
                Grade = (byte)(Grade + 1);
        }
        
        ~SchoolClass()
        {
            Console.WriteLine($"{_grade}.{_gradeLetter} osztály megsemmimsítve.");
        }
    
    }
}
