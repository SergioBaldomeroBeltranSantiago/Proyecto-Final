using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class Conexion
    {

        MySql.Data.MySqlClient.MySqlConnection conexion;
        static string host = "localhost", database = "Proyecto", userDB = "root", password = "P0k3p9rk";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;

        public bool Open() {

            try
            {
                conexion = new MySqlConnection(strProvider);
                conexion.Open();
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Error de conexion. "+ex.Message, "Informacion");
            }
            return false;
        }

        public void Close() {
            if (conexion.State == ConnectionState.Open) {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public DataSet ExecuteDataSet(string sql) {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader ExecuteReader(string sql) {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql) {
            try {
                int affected;
                MySqlTransaction my_transaction = conexion.BeginTransaction();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                my_transaction.Commit();
                return affected;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
