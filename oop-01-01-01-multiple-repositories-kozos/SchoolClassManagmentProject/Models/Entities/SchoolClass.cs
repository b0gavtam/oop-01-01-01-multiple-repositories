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
        private int _classMoney;


        public SchoolClass() { 
            Grade = byte.MinValue;
            GradeLetter = char.MinValue;
        }
        public SchoolClass(byte grade, char gradeLetter, byte lastGrade)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
            _lastGrade = lastGrade;
            _classMoney = int.MinValue;
        }
        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _lastGrade; private set => _lastGrade = value; }
        public string Name => $"{_grade}. {_gradeLetter}";
        public int ClassMoney { get => _classMoney; private set => _classMoney = value; }
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduate => _grade == _lastGrade;
        public bool IsActive => !HasGraduated;

        public void SetClassMoney(int classMoney)
        {
            _classMoney = classMoney;
        }

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
        public override string ToString()
        {
            return $"{Grade}.{GradeLetter}";
        }

    }
}
