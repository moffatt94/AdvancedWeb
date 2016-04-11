using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using u1265196_MovieRentals.Models;

namespace u1265196_AdWeb.DataAccess
{
    public class CustomerDataAccess
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["MyDatabase"].ToString();
            con = new SqlConnection(constr);

        }

        public bool AddCustomer(Customers obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewCustomer", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FirstName", obj.FirstName);
            com.Parameters.AddWithValue("@LastName", obj.LastName);
            com.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
            com.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Postcode", obj.Postcode);
            com.Parameters.AddWithValue("@Phone", obj.Phone);

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


        public List<Customers> GetAllCustomers()
        {
            connection();
            List<Customers> CustomerList = new List<Customers>();


            SqlCommand com = new SqlCommand("GetCustomers", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                CustomerList.Add(

                    new Customers
                    {

                        CustomerID = Convert.ToInt32(dr["CustomerID"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        AddressLine1 = Convert.ToString(dr["AddressLine1"]),
                        AddressLine2 = Convert.ToString(dr["AddressLine2"]),
                        City = Convert.ToString(dr["City"]),
                        Postcode = Convert.ToString(dr["Postcode"]),
                        Phone = Convert.ToString(dr["Phone"])

                    }


                    );

            }

            return CustomerList;


        }



    }
        }