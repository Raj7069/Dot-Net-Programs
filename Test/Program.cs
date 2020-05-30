using System.IO;
using System;
using MySql.Data.MySqlClient;


class Program
{
    public static void Main(string[] args)
    {
        MySqlConnection con = new MySqlConnection();
        con = new MySqlConnection("Data Source= 'localhost'; Initial Catalog='ecommerce'; uid='root'; password=''");
        try
        {
            con.Open();
        }
        catch(MySqlException e)
        {
            Console.WriteLine(e);
        }
        string query = "select * from demo";
        MySqlCommand cmd = new MySqlCommand(query, con);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            string name = (reader[0]).ToString();
        }
    }
}

