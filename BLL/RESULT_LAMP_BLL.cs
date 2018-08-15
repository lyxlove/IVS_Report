using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;
using Model;
using DAL;

namespace BLL
{
    public class RESULT_LAMP_BLL : IRESULT_LAMP_BLL
    {
        RESULT_LAMP_DAL dal = new RESULT_LAMP_DAL();
        public RESULT_LAMP GetEntityByJCLSH(string strJCLSH)
        {
            return dal.GetEntityByJCLSH(strJCLSH);
        }



        public bool UpdateResultLampEntity(RESULT_LAMP entity)
        {

            return dal.UpdateResultLampEntity(entity);
        }
    }
}
