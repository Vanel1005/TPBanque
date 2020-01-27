﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Classes
{
    public class Account
    {
        private int id;
        private double balance;
        private int customerId;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public int Id { get => id; set => id = value; }
        public double Balance { get => balance; set => balance = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
    }
}
