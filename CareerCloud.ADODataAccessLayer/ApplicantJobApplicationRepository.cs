﻿using System;
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
    class ApplicantJobApplicationRepository : BaseClass,IDataRepository<ApplicantJobApplicationPoco>
    {
        public void Add(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (ApplicantJobApplicationPoco poco in items)
                {
                    cmd.CommandText = @"INSERT INTO[dbo].[Applicant_Educations]
                        ([Id]
                        ,[Applicant]
                        ,[Job]
                        ,[Application_Date])
                    VALUES
                        (@Id
                        ,@Applicant
                        ,@Job
                        ,@Application_Date)";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
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

        public IList<ApplicantJobApplicationPoco> GetAll(params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT[Id]
                    ,[Applicant]
                    ,[Job]
                    ,[Application_Date]
                FROM[dbo].[Applicant_Job_Applications]";
                int counter = 0;
                ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[500];
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Applicant = rdr.GetGuid(1);
                    poco.Job = rdr.GetGuid(2);
                    poco.ApplicationDate = rdr.GetDateTime(3);
                    pocos[counter] = poco;
                    counter++;

                }
                return pocos.Where(a => a != null).ToList();
            }
        }



        public IList<ApplicantJobApplicationPoco> GetList(Func<ApplicantJobApplicationPoco, bool> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(Func<ApplicantJobApplicationPoco, bool> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            ApplicantJobApplicationPoco[] pocos = GetAll().ToArray();
            return pocos.Where(where).ToList().FirstOrDefault();
        }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"DELETE FROM[dbo].[Applicant_Job_Applications]
                                      WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }


            }
        }


        public void Update(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Job_Applications]
                    SET[Id] = @Id
                        ,[Applicant] = @Applicant
                        ,[Job] = @Job
                        ,[Application_Date] = @ApplicationDate
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
