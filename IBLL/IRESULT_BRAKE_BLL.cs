using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
    public interface IRESULT_BRAKE_BLL
    {
        RESULT_BRAKE GetEntityByJCLSH(string strJCLSH);

        bool UpdateResultBrakeEntity(RESULT_BRAKE entity);
    }
}
