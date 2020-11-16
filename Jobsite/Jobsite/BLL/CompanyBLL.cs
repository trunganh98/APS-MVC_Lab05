using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Jobsite.DAL;

namespace Jobsite.BLL
{
    public class CompanyBLL
    {
        public IEnumerable<CompanyDAL> Companies
        {
            get
            {
                string conString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                List<CompanyDAL> companyList = new List<CompanyDAL>();
                using(SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = new 
                }
            }
        }
    }
}
