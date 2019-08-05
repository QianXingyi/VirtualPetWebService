using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace WebService1
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<User> UpdateUserNameByPhone(string uPhone, string newName)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE UserTable SET Uname = '" + newName + "' WHERE UPhone = '" + uPhone + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
            List<User> UserList = new List<User>();

            // Write some SQL statement
            SQL = "select * from UserTable Where UPhone='" + uPhone + "'";

            // Connect to DB
            // Open DB
            conn.Open();

            cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    User s = new User();
                    s.uID = int.Parse(reader["UID"].ToString());
                    s.uname = reader["Uname"].ToString();
                    s.uPass = reader["UPass"].ToString();
                    s.uPhone = reader["UPhone"].ToString();
                    s.phoneID = reader["UPhoneID"].ToString();
                    UserList.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return UserList;
        }
        [WebMethod]
        public List<User> UpdateUserPassByPhone(string uPhone, string newPass)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE UserTable SET UPass = '" + newPass + "' WHERE UPhone = '" + uPhone + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
            List<User> UserList = new List<User>();

            // Write some SQL statement
            SQL = "select * from UserTable Where UPhone='" + uPhone + "'";

            // Connect to DB
            // Open DB
            conn.Open();

            cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    User s = new User();
                    s.uID = int.Parse(reader["UID"].ToString());
                    s.uname = reader["Uname"].ToString();
                    s.uPass = reader["UPass"].ToString();
                    s.uPhone = reader["UPhone"].ToString();
                    s.phoneID = reader["UPhoneID"].ToString();
                    UserList.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return UserList;
        }
        [WebMethod]
        public void UpdateUserName(string uID, string newName)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE UserTable SET Uname = '" + newName + "' WHERE UID = '" + uID + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
        }
        [WebMethod]
        public void UpdateUserPass(string uID, string newPass)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE UserTable SET UPass = '" + newPass + "' WHERE UID = '" + uID + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
        }
        [WebMethod]
        public void InsertUserDetails(string uname, string uPass, string uPhone,string phoneID)
        {
            // Write some SQL INSERT statement
            string SQL = "INSERT INTO UserTable VALUES ('" + uname + "', " + uPass + ",'" + uPhone + "','" + phoneID + "')";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
        }
        [WebMethod]
        public void InsertPetDetails(int uID, string pName, int pL, int pHP, int pDP, int pB, int exp, long pCt, long pFt, long pBt,long pCot)
        {
            // Write some SQL INSERT statement
            string SQL = "INSERT INTO PetTable VALUES ('" + uID + "', '" + pName + "','" + pL + "','" + pHP + "','" + pDP + "','" + pB + "','" + exp + "','" + pCt + "','" + pFt + "','" + pBt + "','" + pCot + "')";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
        }

        [WebMethod]
        public List<User> GetAllUser()
        {
            List<User> UserList = new List<User>();

            // Write some SQL statement
            string SQL = "select * from UserTable";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    User s = new User();
                    s.uID = int.Parse(reader["UID"].ToString());
                    s.uname = reader["Uname"].ToString();
                    s.uPass = reader["UPass"].ToString();
                    s.uPhone = reader["UPhone"].ToString();
                    s.phoneID = reader["UPhoneID"].ToString();
                    UserList.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return UserList;
        }
        [WebMethod]
        public List<Pet> GetAllPet()
        {
            List<Pet> PetList = new List<Pet>();

            // Write some SQL statement
            string SQL = "select * from PetTable";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Pet p = new Pet();
                    p.uID = int.Parse(reader["UID"].ToString());
                    p.pName = reader["PName"].ToString();
                    p.pLevel = int.Parse(reader["PLevel"].ToString());
                    p.pHungerPoint = int.Parse(reader["PHungerPoint"].ToString());
                    p.pDirtyPoint = int.Parse(reader["PDirtyPoint"].ToString());
                    p.balance = int.Parse(reader["PBalance"].ToString());
                    p.exp = int.Parse(reader["PExp"].ToString());
                    p.cleanTime = long.Parse(reader["PCleanTime"].ToString());
                    p.feedTime = long.Parse(reader["PFeedTime"].ToString());
                    p.bathTime = long.Parse(reader["PBathTime"].ToString());
                    p.collectTime = long.Parse(reader["PCollectTime"].ToString());
                    PetList.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return PetList;
        }

        [WebMethod]
        public List<Pet> FindPet(int searchstring) {
            List<Pet> PetList = new List<Pet>();

            // Write some SQL statement
            string SQL = "select * from PetTable where uID="+searchstring;

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Pet p = new Pet();
                    p.uID = int.Parse(reader["UID"].ToString());
                    p.pName = reader["PName"].ToString();
                    p.pLevel = int.Parse(reader["PLevel"].ToString());
                    p.pHungerPoint = int.Parse(reader["PHungerPoint"].ToString());
                    p.pDirtyPoint = int.Parse(reader["PDirtyPoint"].ToString());
                    p.balance = int.Parse(reader["PBalance"].ToString());
                    p.exp = int.Parse(reader["PExp"].ToString());
                    p.cleanTime = long.Parse(reader["PCleanTime"].ToString());
                    p.feedTime = long.Parse(reader["PFeedTime"].ToString());
                    p.bathTime = long.Parse(reader["PBathTime"].ToString());
                    p.collectTime = long.Parse(reader["PCollectTime"].ToString());
                    PetList.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return PetList;
        }
        [WebMethod]
        public List<Pet> UpdatePet(int uID, int pL, int pHP, int pDP,int pB,int exp,long pCt,long pFt,long pBt,long pCot)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE PetTable SET PLevel = '" + pL + "', PHungerPoint= '" + pHP + "', PDirtyPoint='" + pDP + "', PBalance='" + pB + "', PExp='" + exp + "', PCleanTime='" + pCt + "', PFeedTime='" + pFt + "', PBathTime='" + pBt + "', PCollectTime='" + pCot + "' WHERE UID = '" + uID + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
            List<Pet> PetList = new List<Pet>();

            // Write some SQL statement
            SQL = "select * from PetTable Where UID='" + uID + "'";

            // Connect to DB
            // Open DB
            conn.Open();

            cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Pet p = new Pet();
                    p.uID = int.Parse(reader["UID"].ToString());
                    p.pName = reader["PName"].ToString();
                    p.pLevel = int.Parse(reader["PLevel"].ToString());
                    p.pHungerPoint = int.Parse(reader["PHungerPoint"].ToString());
                    p.pDirtyPoint = int.Parse(reader["PDirtyPoint"].ToString());
                    p.balance = int.Parse(reader["PBalance"].ToString());
                    p.exp = int.Parse(reader["PExp"].ToString());
                    p.cleanTime = long.Parse(reader["PCleanTime"].ToString());
                    p.feedTime = long.Parse(reader["PFeedTime"].ToString());
                    p.bathTime = long.Parse(reader["PBathTime"].ToString());
                    p.collectTime = long.Parse(reader["PCollectTime"].ToString());
                    PetList.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return PetList;
        }
        [WebMethod]
        public List<User> FindUserByName(string searchstring)
        {
            List<User> UserList = new List<User>();

            // Write some SQL statement
            string SQL = "SELECT * FROM UserTable WHERE Uname LIKE '%" + searchstring + "%'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    User s = new User();

                    s.uID = int.Parse(reader["UID"].ToString());
                    s.uname = reader["Uname"].ToString();
                    s.uPass = reader["UPass"].ToString();
                    s.uPhone = reader["UPhone"].ToString();
                    s.phoneID = reader["UPhoneID"].ToString();
                    UserList.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return UserList;
        }
        [WebMethod]
        public List<User> FindUserByPhone(string searchstring)
        {
            List<User> UserList = new List<User>();

            // Write some SQL statement
            string SQL = "SELECT * FROM UserTable WHERE UPhone LIKE '%" + searchstring + "%'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    User s = new User();

                    s.uID = int.Parse(reader["UID"].ToString());
                    s.uname = reader["Uname"].ToString();
                    s.uPass = reader["UPass"].ToString();
                    s.uPhone = reader["UPhone"].ToString();
                    s.phoneID = reader["UPhoneID"].ToString();
                    UserList.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            conn.Close();

            return UserList;
        }
        [WebMethod]
        public void UpdateUserPhoneID(string uID, string newPhoneID)
        {
            // Write some SQL INSERT statement
            string SQL = "UPDATE UserTable SET UPhoneID = '" + newPhoneID + "' WHERE UID = '" + uID + "'";

            // Connect to DB
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebService1.Properties.Settings.Setting"].ToString());
            // Open DB
            conn.Open();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            // Execute SQL command
            cmd.ExecuteNonQuery();

            // Close & Disconnect from DB
            conn.Close();
        }
       
    }
}