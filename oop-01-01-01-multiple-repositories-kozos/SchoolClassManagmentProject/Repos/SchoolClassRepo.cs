using SchoolClassManagmentProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassManagmentProject.Repos
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;
        public SchoolClassRepo() 
        { 
            _schoolClasses = new List<SchoolClass>();
        }
        public int NumberOfSchoolClasses => _schoolClasses.Count;

        public void Add(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }
        public void Remove(int grade, char gradeLetter)
        { 
            SchoolClass? schoolClassToRemove = _schoolClasses.Find(schoolClass => schoolClass.Grade == grade && schoolClass.GradeLetter == gradeLetter);
            if (schoolClassToRemove is not null)
            {

                _schoolClasses.Remove(schoolClassToRemove);
            }
        }
        /* public int GetNumberOfGraduateClasses()
         {
             return _schoolClasses.Count(schoolClass => schoolClass.IsGraduate);
         }*/
        public List<SchoolClass> GetGraduateClasses()
        {
            return _schoolClasses.Where(schoolClass => schoolClass.IsGraduate).ToList();
        }
        public int GetClassMoneyPerStudentInOneYear(int grade, char gradeLetter)
        {
          return  _schoolClasses.Find(schoolClass => schoolClass.Grade == grade && schoolClass.GradeLetter == gradeLetter).ClassMoney * 10;
        }
    }
}
