using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCYLabourClient.DBUtility;
using DCYLabourClient.MODEL;
using System.Data.SqlClient;

namespace DCYLabourClient.DAL
{
    public class UserInfDal
    {
        public string GetTNameByUid(string uid)
        {
            return SqlHelper.ExecuteScalar("select TName from TeacherInf where TUid =@para1",
                new SqlParameter("@para1",uid)).ToString();
        }

        public string GetStuNameByCard(string taskStuCapID)
        {
            return SqlHelper.ExecuteScalar("select SName from Student where SCardNum =@para1",
                new SqlParameter("@para1", taskStuCapID)).ToString();
        }
    }
}
