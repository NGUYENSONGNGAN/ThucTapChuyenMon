using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThucTapCM.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;//ctrl + R +E
        private string Connection = @"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS;Initial Catalog=DOANCHUYENMON7;Integrated Security=True";

        public static DataProvider Instance
        { get {  if (instance == null) instance = new DataProvider();return DataProvider.instance; }
            private set => instance = value; }

        public DataTable ExecuteQuery(string query , object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if(parameter !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteNonQuery();
                
                sqlConnection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                        }
                    }
                }
                data = sqlCommand.ExecuteScalar();

                sqlConnection.Close();
            }
            return data;
        }
    }
}
