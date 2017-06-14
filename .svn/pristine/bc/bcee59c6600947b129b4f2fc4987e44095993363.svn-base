using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TrainingManagement
{
    class sqlConnect
    {
        public SqlConnection cnn = new SqlConnection("Data Source=(local);Inital Catalog=trainmanage;Intergrated Security=True");
        public static string text = @"SERVER = .\K55VD; DATABASE = trainmanage; Intergrated Security=True";
        public void myconnect()
        {
            cnn.Open();

        }
        public void myclose()
        {
            cnn.Close();
        }
    }
}
