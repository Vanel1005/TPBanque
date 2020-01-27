using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Classes
{
    class Customer
    {
        private int id;
        private String firstName;
        private String lastName;
        private String phoneNumber;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public void Save()
        {
            //fonction pour enregistrer dans la BDD
        }

        public Customer Get()
        {
            //fonction pour recupeer un user
            return new Customer();
        }
    }
}
