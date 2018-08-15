using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using IBLL;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class RESULT_VEHICLE_INFO_BLL : IRESULT_VEHICLE_INFO_BLL
    {
        RESULT_VEHICLE_INFO_DAL dal = new RESULT_VEHICLE_INFO_DAL();



        public List<RESULT_VEHICLE_INFO> GetResultVehicleList()
        {
            return dal.GetResultVehicleList();
        }

        public bool UpdateResultVehicleInfo(RESULT_VEHICLE_INFO info)
        {
            dal.UpdateResultVehicleInfo(info);
            return false;
        }


        public DataSet GetVehicleResultDataSet()
        {
            return dal.GetVehicleResultDataSet();
        }

        public RESULT_VEHICLE_INFO GetResultVehicleInfoByJCLSH(string strJCLSH)
        {
            return dal.GetResultVehicleInfoByJCLSH(strJCLSH);
        }
    }
}