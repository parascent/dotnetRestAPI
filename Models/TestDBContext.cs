// using MySql.Data.MySqlClient;
// using System;
// using System.Collections.Generic;

// namespace dotnetapi.Models
// {
//     public class TestDBContext
//     {
//         public string ConnectionString { get; set; }

//         public TestDBContext(string connectionString)
//         {
//             this.ConnectionString = connectionString;
//         }

//         private MySqlConnection GetConnection()
//         {
//             return new MySqlConnection(ConnectionString);
//         }

//         public List<Test> GetAllTest()
//         {
//             List<Test> list = new List<Test>();
//             using (MySqlConnection conn = GetConnection())
//             {
//                 conn.Open();
//                 MySqlCommand cmd = new MySqlCommand("select * from test where id < 10", conn);
//                 using (var reader = cmd.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         list.Add(new Test()
//                         {
//                             id = Convert.ToInt32(reader["id"]),
//                             text = reader["text"].ToString(),
//                         });
//                     }
//                 }
//             }
            
//             return list;  
//         }


//         public  Test GetById(string id){
//             using (MySqlConnection conn = GetConnection())
//             {
//                 conn.Open();
//                 MySqlCommand cmd = new MySqlCommand("select * from test where id = "+ id, conn);
//                 using (var reader = cmd.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         list.Add(new Test()
//                         {
//                             id = Convert.ToInt32(reader["id"]),
//                             text = reader["text"].ToString(),
//                         });
//                     }
//                 }
//             }
            
//             return list; 
//         } 







//     }
// }