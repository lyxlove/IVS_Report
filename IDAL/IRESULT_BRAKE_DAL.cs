using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IDAL
{
    public interface IRESULT_BRAKE_DAL
    {
        RESULT_BRAKE GetEntityByJCLSH(string strJCLSH);

        bool UpdateResultBrakeEntity(RESULT_BRAKE entity);
    }
}
