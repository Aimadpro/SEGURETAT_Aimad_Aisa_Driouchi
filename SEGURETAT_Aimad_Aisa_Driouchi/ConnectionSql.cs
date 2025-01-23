using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGURETAT_Aimad_Aisa_Driouchi
{
    public static class ConnectionSql
    {
        public static SqlConnection connexio = new SqlConnection("Server=localhost; Database=seguretat; Integrated Security=True");
    }

}
