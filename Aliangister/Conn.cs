using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliangister
{
    class Conn
    {
        //
        // conectar ao banco de dados
        //
        /*
        private static string server = @"JUN0675598W10-1\DBSENAC";
        private static string dataBase = "usinagem_alianca_db";
        private static string user = "senaclivre";
        private static string password = "senaclivre";
        */
        public static string StrCon
        {
            //get { return "Data Source =" + server + "; Integrated Security = False; Initial Catalog =" + dataBase + "; User ID =" + user + "; Password =" + password; }
            //get { return $"Data Source={server};Initial Catalog={dataBase}; User ID={user};Password={password}"; }
            get { return @"Data Source=JUN0675598W10-1\BDSENAC;Initial Catalog=usinagem_alianca_db; User ID=senaclivre;Password=senaclivre"; }
        }
    }
}
