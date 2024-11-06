namespace Lecture12;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
      string connStr = "server=34.69.59.37;user=jlbarrientez1;database=jlbarrientez1;port=8080;password=jlbarrientez1";
       MySqlConnection conn = new MySqlConnection(connStr);
       try
       {
           Console.WriteLine("Connecting to MySQL...");
           conn.Open();
            // input information for new record
           Console.WriteLine("Enter Username:");
           string? input_username = Console.ReadLine();
           Console.WriteLine("Enter Password:");
           string? input_password = Console.ReadLine();
           // sql: count how many records match inputUsername and inputPassword
           // save the counted number into variable countUser
           string sql = @"SELECT COUNT(*) AS countUser FROM User
                   WHERE
                   User.username = @inputUsername
                   AND
                   User.password = @inputPassword;";
           MySqlCommand cmd = new MySqlCommand(sql, conn);
           cmd.Parameters.AddWithValue("@inputUsername", input_username);
           cmd.Parameters.AddWithValue("@inputPassword", input_password);
           MySqlDataReader rdr = cmd.ExecuteReader();
           while (rdr.Read())
           {   // if countUser equals to 1, means can find input values in table
               if(rdr["countUser"].ToString() == "1"){
                   Console.WriteLine("Login Successfully!");
               }
               else{
                   Console.WriteLine("Login Failed!");
               }
           }
                 rdr.Close();
           // convert returned value to int datatype
       }

       catch (Exception ex)
       {
           Console.WriteLine(ex.ToString());
       }

       conn.Close();
       Console.WriteLine("Done.");
   }
}

       
    
