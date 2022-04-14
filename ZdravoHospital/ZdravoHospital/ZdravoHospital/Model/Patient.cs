using System;

namespace Model
{
    public class Patient
    {
        public string jmbg { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string recordNumber { get; set; }
        public Gender gender { get; set; }

        public Patient( string jmbg, string name, string surname, string address, string phoneNumber, string dateOfBirth, string recordNumber, Gender gender)
        {
            this.jmbg = jmbg;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.recordNumber = recordNumber;
            this.gender = gender;
        }

        public Patient()
        {
        }
    }
}
