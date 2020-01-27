using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Classes
{
    class Configuration
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\BanqueApp;Integrated Security=True");
    }
}
