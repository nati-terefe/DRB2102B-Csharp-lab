﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace lec_8
{
    internal class Class1
    {
        private static List<Class1> product = new List<Class1>();

        public string idtext { get; set; }
        public string fntext { get; set; }
        public string lntext { get; set; }
        public string addresstext { get; set; }
        public string datetext { get; set; }
        public string gendertext { get; set; }

      
        public void save()
        {
            product.Add(this);
            try
            {
                String connectionstring2 = @"Data Source=HP\SQLEXPRESS; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con2 = new SqlConnection(connectionstring2);
                SqlDataReader result = null;
                con2.Open();

                string query2 = "select id,fname,lname,_address,_date,gender from student;";
                SqlCommand com2 = new SqlCommand(query2, con2);

                result = com2.ExecuteReader();



                while (result.Read())
                {
                    idtext = result["id"].ToString();
                    fntext = result["fname"].ToString();
                    lntext = result["lname"].ToString();
                    addresstext = result["_address"].ToString();
                    datetext = result["_date"].ToString();
                    gendertext = result["gender"].ToString();

                }






                String connectionstring = @"Data Source=HP\SQLEXPRESS; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                string query = "insert into student(id,fname,lname,_address,_date,gender) values(@id,@fn,@ln,@address,@date,@gender);";//"insert into student values ('ss' ,'ddd');";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@id", idtext);
                com.Parameters.AddWithValue("@fn", fntext);
                com.Parameters.AddWithValue("@ln", lntext);
                com.Parameters.AddWithValue("@address", addresstext);
                com.Parameters.AddWithValue("@date", "August");
                com.Parameters.AddWithValue("@gender", gendertext);
                //var result = com.ExecuteReader();
                com.ExecuteNonQuery();
                
                
                
                
                
                
            }
            catch
            {
                Console.WriteLine("error");
            };
           

        }

        public static SqlDataReader re()
        {
            
                String connectionstring = @"Data Source=HP\SQLEXPRESS; Initial Catalog=csharp; Integrated Security=true";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataReader result = null;
                con.Open();
            try { 
                string query2 = "select id,fname,lname,_address,_date,gender from student;";
                SqlCommand com2 = new SqlCommand(query2, con);

                result = com2.ExecuteReader();
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
            /*while (result.Read())
            {
                idtext = result["id"].ToString();
                fntext = result["fname"].ToString();
                lntext = result["lname"].ToString();
                addresstext = result["_address"].ToString();
                datetext = result["_date"].ToString();
                gendertext = result["gender"].ToString();
                com2.ExecuteReader();
            } */

        }



        public static List<Class1> getall()
        {
            return product;


            
            // we exe select statement
            // SqlConnection con = new SqlConnection(//data source //intital cataloge //integrated security(true if windows authentication and user and pswrd if its sql));
            //);
            //String connectionstring = @"datasource=; intial catalog=test(dbname); intergrated security=true;";
            //con.open();
            //messagebox()"
        } 

    }
}
