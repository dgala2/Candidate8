using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    public enum Genders
    {
        Male = 1,
        Female
    }
    public class Customer
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Genders Gender { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int _age = now.Year - DateOfBirth.Year;
                if (now < DateOfBirth.AddYears(_age)) _age--;
                return _age;
            }
        }
       
        
    }
   
}
