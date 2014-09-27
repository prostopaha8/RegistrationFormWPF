using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WpfApplication1
{
    static class BussinesLayer
    {
        private static string cnStr;
        private static string provider;

        private static string Provider
        {
            get { return BussinesLayer.provider; }
        }
        private static string CnStr
        {
            get { return BussinesLayer.cnStr; }
        }
        private static DbProviderFactory df;
        static BussinesLayer()
        {
            provider = ConfigurationSettings.AppSettings.Get("provider");
            cnStr = ConfigurationSettings.AppSettings.Get("cnStr");
            df = DbProviderFactories.GetFactory(Provider);
        }
        public static void SetData(DataModel data)
        {
            using (DbConnection cn = df.CreateConnection())
            {
                cn.ConnectionString = CnStr;
                cn.Open();

                DbCommand cmd = df.CreateCommand();
                cmd.Connection = cn;

                string commandInsert = String.Format("Insert into [dbo].[user]"+
                    "(id,name,surname,nickname) Values"+
                    "('{0}','{1}','{2}','{3}')",5,"qqq","rrr","uuu");
                SqlConnection sqlCn = new SqlConnection();
                sqlCn.ConnectionString = CnStr;
                sqlCn.Open();
                using(SqlCommand sqlCmd = new SqlCommand(commandInsert,sqlCn))
                {
                    sqlCmd.ExecuteNonQuery();
                }

                //using (DbDataReader dr = cmd.ExecuteReader())
                //{
                //    System.Windows.MessageBox.Show(dr["name"].ToString());
                //}
            }
        }

    }
}
