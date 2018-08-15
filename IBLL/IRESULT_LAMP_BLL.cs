using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IBLL
{
    public interface IRESULT_LAMP_BLL
    {
        RESULT_LAMP GetEntityByJCLSH(string strJCLSH);

        bool UpdateResultLampEntity(RESULT_LAMP entity);
    }
}
