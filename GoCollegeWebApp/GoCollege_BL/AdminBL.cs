using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoCollege_BL;
using GoCollege_CL;
using GoCollege_DL;
using System.Data;


namespace GoCollege_BL
{   

    public class AdminBL
    {
          AdminDL objAdmiDL = new AdminDL();

        PasswordBL objPasswordBL = new PasswordBL();
        
        //Variables

        public DataView AdminLogin(string adminUN,string adminPWD)
        {
               DataView dvMsg=null;
               Connection conn = new Connection();
               try
               {
                   conn.BeginTransaction();

                   string encryptedPassword = objPasswordBL.GenerateHash(adminPWD);
                   adminPWD = encryptedPassword;

                   dvMsg = objAdmiDL.FetchAdminDetails(conn.con, conn.trans, adminUN, adminPWD);

                   if (dvMsg.Count.Equals(0))
                   {
                       return dvMsg.Table.DefaultView;

                   }

                   return dvMsg.Table.DefaultView;

               }
               catch (NullReferenceException ex)
               {

               }
               catch (Exception ex)
               {
               
               }
               return dvMsg.Table.DefaultView;

        }

        //public DataView GetdvMsg()
        //{
        //    return dvMsg;
        //}

        
    }

}
