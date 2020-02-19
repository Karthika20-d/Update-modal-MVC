//using System.Collections.Generic;
//using System.Collections;
//using System.Data;
//using System;
//using OnlineRealEstateEntity;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace OnlineRealEstateRepositary
//{

//    class UserRepositary
//    {
//        //internal Dictionary<int, Admin> user = new Dictionary<int, Admin>();
//        static SqlConnection sqlConnection = UserRepositary.GetDBConnection();
//        //internal static                           string propertyType;
//        public static ArrayList GetLocationList()
//        {
//            DataSet userDetails = new DataSet();
//            ArrayList locationList = new ArrayList();
//            string selectQuery = "SPSelect";
//            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlConnection);
//            adapter.Fill(userDetails, "UserDetails");
//            foreach (DataTable data in userDetails.Tables)
//            {
//                if (data.TableName == "UserDetails")
//                {
//                    for (int row = 0; row < data.Rows.Count; row++)
//                    {
//                        foreach (DataColumn column in data.Columns)
//                            if (Convert.ToString(column) == "Location")
//                            {
//                                for (int rowColumn = 0; rowColumn < data.Columns.Count; rowColumn++)
//                                {
//                                    locationList.Add(Convert.ToString(data.Rows[row][rowColumn]));
//                                }
//                            }

//                    }
//                }
//            }
//            return locationList;
//        }
//        public int SignUp(UserManager userManager)
//        {

//            sqlConnection.Open();
//            string insertQuery = "SPInsert";
//            using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
//            {
//                sqlCommand.CommandType = CommandType.StoredProcedure;
//                SqlParameter param = new SqlParameter();
//                param.ParameterName = "@UserName";
//                param.Value = userManager.name;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);

//                param = new SqlParameter();
//                param.ParameterName = "@Password";
//                param.Value = userManager.password;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);

//                param = new SqlParameter();
//                param.ParameterName = "@Mail_id";
//                param.Value = userManager.email;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);

//                param = new SqlParameter();
//                param.ParameterName = "@Location";
//                param.Value = userManager.location;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);

//                param = new SqlParameter();
//                param.ParameterName = "@Phone_Number";
//                param.Value = userManager.phoneNumber;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);

//                param = new SqlParameter();
//                param.ParameterName = "@Role";
//                param.Value = userManager.role;
//                param.SqlDbType = SqlDbType.VarChar;
//                sqlCommand.Parameters.Add(param);
//                int userID = Convert.ToInt32(sqlCommand.ExecuteScalar());
//                int rows = sqlCommand.ExecuteNonQuery();
//                    //Admin admin = new Admin(userID, userData);
//                    // user.Add(userID, admin);
//                    sqlCommand.Dispose();
//                    sqlConnection.Close();
//                    return userID;

//            }

//        }
//        public static SqlConnection GetDBConnection()
//        {
//            string connectionstring = ConfigurationManager.ConnectionStrings["RealEstate"].ConnectionString;
//            SqlConnection sqlConnection = new SqlConnection(connectionstring);
//            return sqlConnection;
//        }
//    }
//}
