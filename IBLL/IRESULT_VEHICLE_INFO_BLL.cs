using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Model;

namespace IBLL
{
    public interface IRESULT_VEHICLE_INFO_BLL
    {
        List<RESULT_VEHICLE_INFO> GetResultVehicleList();

        bool UpdateResultVehicleInfo(RESULT_VEHICLE_INFO info);

        RESULT_VEHICLE_INFO GetResultVehicleInfoByJCLSH(string strJCLSH);

        DataSet GetVehicleResultDataSet();


    }
}
