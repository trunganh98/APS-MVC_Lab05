using Jobsitewk12.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Jobsitewk12.BLL
{
    public class CompanyBLL
    {
        public IEnumerable<CompanyDAL> Companies
        {
            get
            {
                string conString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                List<CompanyDAL> companyList = new List<CompanyDAL>();
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand("select * from Company", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CompanyDAL companyObj = new CompanyDAL();
                        companyObj.CompanyId = Convert.ToInt32(dr["CompanyId"]);
                        companyObj.Name = dr["Name"].ToString();
                        companyObj.Email = dr["Email"].ToString();
                        companyObj.City = dr["City"].ToString();

                        companyList.Add(companyObj);
                    }
                }
                return companyList;
            }
        }
    }
}