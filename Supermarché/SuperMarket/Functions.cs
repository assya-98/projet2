using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
   class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String ConString;

        public Functions ()
        {
            ConString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\akassim\\Desktop\\SuperMarket\\SuperMarket\\SuperMarcheBD.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable RecupererDonnees(string Req)
        {

            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConString);
            sda.Fill(dt);
            return dt;
        }


        public int EnvoyerDonnes (string Req)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            Cmd.CommandText = Req;
            cnt = Cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
