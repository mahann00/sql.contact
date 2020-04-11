using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class MyContact : IMyContactRepository
    {
        private string Connectionstring = "Data Source=.;Initial Catalog=MyContact;Integrated Security=true";

        public bool Delete(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string Name, string Familly, string Email, int Age)
        {
            throw new NotImplementedException();
        }

        public DataTable Selectall()
        {
            string query = "Select * from MyContacts";
            SqlConnection Connect = new SqlConnection(Connectionstring);

            SqlDataAdapter Adapter = new SqlDataAdapter(query,Connect);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;

        }

        public DataTable Selectrow(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string Name, string Familly, string Emile, int Age)
        {
            throw new NotImplementedException();
        }
    }
}
