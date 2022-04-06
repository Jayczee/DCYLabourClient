using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCYLabourClient.DAL;
using DCYLabourClient.MODEL;

namespace DCYLabourClient.BLL
{
    public class UserInfBll
    {
        UserInfDal udal=new UserInfDal();
        public string GetTNameByUid(string uid)
        {
            return udal.GetTNameByUid(uid);
        }

        public string GetStuNameByCard(string taskStuCapID)
        {
            return udal.GetStuNameByCard(taskStuCapID);
        }
    }
}
