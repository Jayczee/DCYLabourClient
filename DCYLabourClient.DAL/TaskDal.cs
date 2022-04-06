using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DCYLabourClient.DBUtility;
using DCYLabourClient.MODEL;

namespace DCYLabourClient.DAL
{
    public class TaskDal
    {
        public DataTable GetTaskList(string stucardnum)
        {
            return SqlHelper.ExecuteTable("select * from LabourTaskInf where TaskStuCapID = @para1 and (TaskCon = 0 or TaskCon = 1)",
                new SqlParameter("@para1",stucardnum));
        }

        public DataTable GetFinishInfo(int taskid)
        {
            return SqlHelper.ExecuteTable("select * from TaskFinishInfo where TaskID=@para1",
                new SqlParameter("@para1",taskid));
        }

        public void AddFinishInfo(int taskID)
        {
            SqlHelper.ExecuteNonQuery("insert into TaskFinishInfo(TaskID)values(@para1)",
                    new SqlParameter("@para1", taskID));
        }
    }
}
