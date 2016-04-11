using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using u1265196_MovieRentals.Models;

namespace u1265196_MovieRentals.DataAccess
{
    public class MoviesDataAccess
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDatabase"].ToString();
            con = new SqlConnection(constr);

        }

        public bool AddMovie(Movies obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewMovie", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Title", obj.Title);
            com.Parameters.AddWithValue("@Director", obj.Director);
            com.Parameters.AddWithValue("@Genre", obj.Genre);
            com.Parameters.AddWithValue("@Length", obj.Length);
            com.Parameters.AddWithValue("@AgeRating", obj.AgeRating);


            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
    }
}