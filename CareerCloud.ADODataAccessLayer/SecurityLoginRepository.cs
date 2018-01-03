using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    class SecurityLoginRepository : BaseClass,IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (SecurityLoginPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Security_Logins]
                                        ([Id]
                                        ,[Login]
                                        ,[Password]
                                        ,[Salt]
                                        ,[Created_Date]
                                        ,[Password_Update_Dated]
                                        ,[Agreement_Accepted_Date]
                                        ,[Is_Locked]
                                        ,[Is_Inactive]
                                        ,[Email_Address]
                                        ,[Phone_Number]
                                        ,[Full_Name]
                                        ,[Force_Change_Password]
                                        ,[Prefferred_Language])
                                    VALUES
                                        (@Id
                                        ,@Login
                                        ,@Password
                                        ,@Salt
                                        ,@Created_Date
                                        ,@Password_Update_Dated
                                        ,@Agreement_Accepted_Date
                                        ,@Is_Locked
                                        ,@Is_Inactive
                                        ,@Email_Address
                                        ,@Phone_Number
                                        ,@Full_Name
                                        ,@Force_Change_Password
                                        ,@Prefferred_Language)";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }

            }

        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                                      ,[Login]
                                      ,[Password]
                                      ,[Salt]
                                      ,[Created_Date]
                                      ,[Password_Update_Dated]
                                      ,[Agreement_Accepted_Date]
                                      ,[Is_Locked]
                                      ,[Is_Inactive]
                                      ,[Email_Address]
                                      ,[Phone_Number]
                                      ,[Full_Name]
                                      ,[Force_Change_Password]
                                      ,[Prefferred_Language]
                                      ,[Time_Stamp]
                                  FROM [dbo].[Security_Logins]";
                int counter = 0;
                SecurityLoginPoco[] pocos = new SecurityLoginPoco[500];
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SecurityLoginPoco poco = new SecurityLoginPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Login = rdr.GetString(1);
                    poco.Password = rdr.GetString(2);
                    poco.Created = rdr.GetDateTime(3);
                    poco.PasswordUpdate = rdr.GetDateTime(4);
                    poco.AgreementAccepted = rdr.GetDateTime(5);
                    poco.IsLocked = rdr.GetBoolean(6);
                    poco.IsInactive = rdr.GetBoolean(7);
                    poco.EmailAddress = rdr.GetString(8);
                    poco.PhoneNumber = rdr.GetString(9);
                    poco.FullName = rdr.GetString(10);
                    poco.PhoneNumber = rdr.GetString(11);
                    poco.ForceChangePassword = rdr.GetBoolean(12);
                    poco.PrefferredLanguage = rdr.GetString(13);
                    poco.TimeStamp = (byte[])rdr[14];

                    pocos[counter] = poco;
                    counter++;
                }
                return pocos.Where(a => a != null).ToList();
            }
        }


        public IList<SecurityLoginPoco> GetList(Func<SecurityLoginPoco, bool> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(Func<SecurityLoginPoco, bool> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            SecurityLoginPoco[] pocos = GetAll().ToArray();
            return pocos.Where(where).ToList().FirstOrDefault();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Security_Logins]
                                 WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }


            }
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Security_Logins]
                                       SET [Id] = @Id
                                          ,[Login] = @Login
                                          ,[Password] = @Password
                                          ,[Created_Date] = @Created_Date
                                          ,[Password_Update_Dated] = @Password_Update_Dated
                                          ,[Agreement_Accepted_Date] = @Agreement_Accepted_Date
                                          ,[Is_Locked] = @Is_Locked
                                          ,[Is_Inactive] = @Is_Inactive
                                          ,[Email_Address] = @Email_Address
                                          ,[Phone_Number] = @Phone_Number
                                          ,[Full_Name] = @Full_Name
                                          ,[Force_Change_Password] = @Force_Change_Password
                                          ,[Prefferred_Language] = @Prefferred_Language
                                          WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

            }


        }

    }
}
