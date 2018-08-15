using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using Model;
using UserTools;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DAL
{
    public class RESULT_BRAKE_DAL : IRESULT_BRAKE_DAL
    {

        public RESULT_BRAKE GetEntityByJCLSH(string strJCLSH)
        {
            SqlDataReader sdr = SqlHelper.ExecuteReader(CommandType.Text, string.Format("SELECT  *  FROM  RESULT_BRAKE WHERE JCLSH = '{0}'", strJCLSH));
            RESULT_BRAKE entity = EntityHelper.FillEntity<RESULT_BRAKE>(sdr);
            return entity;
        }

        public bool UpdateResultBrakeEntity(RESULT_BRAKE entity)
        {
            bool succ = false;
            PropertyInfo[] propertyInfos = entity.GetType().GetProperties();
            string strSql = "UPDATE RESULT_BRAKE SET ";
            foreach (PropertyInfo p in propertyInfos)
            {
                if (p.Name != "ID" && p.Name != "JCLSH")
                {
                    strSql += string.Format("{0}='{1}',", p.Name, p.GetValue(entity, null));
                }
            }
            strSql = strSql.Substring(0, strSql.Length - 1);
            strSql += string.Format(" WHERE JCLSH ='{0}'", entity.JCLSH);
            int i  = SqlHelper.ExcuteNonQuery(CommandType.Text, strSql);

            if (i > 0)
                succ = true;
            return succ;
        }
    }
}
