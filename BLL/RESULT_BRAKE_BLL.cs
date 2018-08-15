using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;
using Model;
using DAL;

namespace BLL
{
    public class RESULT_BRAKE_BLL : IRESULT_BRAKE_BLL
    {
        RESULT_BRAKE_DAL dal = new RESULT_BRAKE_DAL();
        public RESULT_BRAKE GetEntityByJCLSH(string strJCLSH)
        {
            return dal.GetEntityByJCLSH(strJCLSH);
        }

        public bool UpdateResultBrakeEntity(RESULT_BRAKE entity)
        {
            return dal.UpdateResultBrakeEntity(entity);
        }
    }
}
