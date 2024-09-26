using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SchoolClassManagmentProject.Models.AppException;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class Student
    {
        private string _lastName;
        private string _firstName;
        private bool _gender;
        private DateTime _birthDate;
        private string _email;
        private string _phone;
        //legyen üres konstruktor
        //legyen összes konstruktor
        //lehessen létrehozni diákot email cím nélkül
        //legyen a diák angol és magyar teljes neve
        //lehessen könnyedén email és telefont változtatni, a többit csak nehezen
        //lekérdehető legyen hogy van-e email címe és hogy van-e telefonszáma a diáknak
        
        
        
        
        //kivételkezelés: 
        //névben csak betű és szóközön kívül semmi
        //email címben nincs kukac
        
        
        
        public Student() { 
            _lastName = string.Empty;
            _firstName = string.Empty ;
            _gender =   false;
            _birthDate = DateTime.MinValue;
            _email = string.Empty;
            _phone = string.Empty;
        }

        public Student(string lastName, string firstName, bool gender, DateTime birthDate, string email, string phone)
        {
            _lastName = lastName;
            _firstName = firstName;
            _gender = gender;
            _birthDate = birthDate;
            _email = string.Empty;
            _phone = phone;
        }
        public override string ToString()
        {
            return $"Magyar teljes név: {_lastName} {_firstName}, \n Angol teljes név: {_firstName} {_lastName}";
        }

        public string Email { get => _email = Email; set => _email = value; }
        public string Phone { get => _phone = Phone; set => _phone = value; }
        public string LastName => _lastName = LastName;
        public string FirstName => _firstName = FirstName; 
        public DateTime BirthDate => _birthDate = BirthDate;
        public bool Gender => _gender = Gender;
        public bool HasEmail => !string.IsNullOrEmpty(_email);
        public bool HasPhone => !string.IsNullOrEmpty(_phone);

        public void SetEmail(string newEmail)
        {
            if (newEmail == _email)
                throw new EmailIsSameAsOldException();
            else if (!newEmail.Contains("@"))
                throw new EmailIsSameAsOldException();
            else
                _email = newEmail;
        }
        public int GetAge()
        {
            if (DateTime.Now.Month <= _birthDate.Month && _birthDate.Day < DateTime.Now.Day)
            {
                return DateTime.Now.Year - _birthDate.Year - 1;
            }
                return DateTime.Now.Year - _birthDate.Year;

        }
    }
}
