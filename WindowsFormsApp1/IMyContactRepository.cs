using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1
{
    interface IMyContactRepository
    {
        DataTable Selectall();
        DataTable Selectrow(int ContactID);
        bool Insert(string Name, string Familly, string Email, int Age);
        bool Update(int ContactID,string Name,string Familly,string Emile , int Age);
        bool Delete(int ContactID);
    }
}
