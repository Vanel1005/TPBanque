using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Classes
{
    class Operation
    {
        private int id;
        private double amount;
        private int accountId;

        public int Id { get => id; set => id = value; }
        public double Amount { get => amount; set => amount = value; }
        public int AccountId { get => accountId; set => accountId = value; }

        private static SqlCommand command;
        private static SqlDataReader reader;

    }
}
