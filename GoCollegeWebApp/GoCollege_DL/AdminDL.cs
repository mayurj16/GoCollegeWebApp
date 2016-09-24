using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace GoCollege_DL
{


    public class AdminDL
    {
        public DataView FetchAdminDetails(SqlConnection con, SqlTransaction trans, String adminUN, String adminPWD)
        { 
            DataSet MyDataSet = new DataSet();
            SqlDataAdapter MyDataAdapter;
            SqlCommand cmd = null;
            string qry = "";
            try
            {
                qry = "Select * from tblAdmin where AdminUserName=@UserName and AdminPassword=@Password and AdminStatus in('R','A')";
                cmd = new SqlCommand(qry, con, trans);
                cmd.CommandType = CommandType.Text;
                SqlParameter param;

                // parameter for UserName column
                param = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
                param.Direction = ParameterDirection.Input;
                param.Value = adminUN;
                cmd.Parameters.Add(param);

                // parameter for Password column
                param = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                param.Direction = ParameterDirection.Input;
                param.Value = adminPWD;
                cmd.Parameters.Add(param);

                MyDataAdapter = new SqlDataAdapter(cmd);
                MyDataAdapter.Fill(MyDataSet);
            }

            catch (SqlException SqlEx)
            {
                
            }

            return MyDataSet.Tables[0].DefaultView;        
        }
       

    }
}
