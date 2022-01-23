using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FinalProject.Model
{
    class UserClass
    {
        ModelTemplate temp;


        public UserClass()
        {
            temp = new ModelTemplate();
        }

        public string id { get; set; }
        public string nama { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Boolean CekLogin()
        {
            bool result;
            DataSet ds = new DataSet();
            ds = temp.Select("Ususer", "username = '" + username + "' AND password = '" + password + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool InsertUser()
        {
            string data = "'" + id + "','" +  nama + "','" + username + "','" + password + "'";
            return temp.Insert("Ususer", data);
        }


    }
}
