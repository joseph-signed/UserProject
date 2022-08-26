using System;

namespace ApplicantProject.Models
{
    public class UserModel
    {
        public UserModel() { }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public DateTime RegisterDate { get; set; }

        public string RegisterDateString { get; set; }

        public string FullName { get; set; }
    }
}
