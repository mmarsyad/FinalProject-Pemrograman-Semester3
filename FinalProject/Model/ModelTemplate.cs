using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FinalProject.Model
{
    class ModelTemplate
    {
        private static SqlConnection conn;
        private SqlCommand command;
        private Boolean result;
        
        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-R9B6JK6;" +
                                    "Initial Catalog = FinalProject_3;" +
                                    "Integrated Security = True";

            return conn;
        }

        public ModelTemplate()
        {
            GetConnection();
        }

        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT * FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch(SqlException)
            {
                ds = null;
            }

            conn.Close();
            return ds;
        }

        public Boolean Insert(string tabel, string data)
        {
            result = false;
            try
            {
                string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Update(string tabel, string data, string kondisi)
        {
            result = false;
            try
            {
                string query = "UPDATE " + tabel + " SET " + data + "WHERE" + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Delete(string tabel, string kondisi)
        {
            result = false;
            try
            {
                string query = "DELETE FROM" + tabel +  "WHERE" + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

         /*public void cekKoneksi()
         {
             GetConnection();
             try
             {
                 conn.Open();
                 MessageBox.Show("Koneksi Sukses");
             }
             catch (SqlException se)
             {
                 MessageBox.Show("Koneksi Gagal" + se);
             }
         }*/
    }
}
