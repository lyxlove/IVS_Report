using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using Model;
using UserTools;
namespace DAL
{
    public class RESULT_LAMP_DAL
    {

        public RESULT_LAMP GetEntityByJCLSH(string strJCLSH)
        {
            SqlDataReader sdr = SqlHelper.ExecuteReader(CommandType.Text, string.Format("SELECT  *  FROM  RESULT_LAMP WHERE JCLSH = '{0}'", strJCLSH));
            RESULT_LAMP entity = EntityHelper.FillEntity<RESULT_LAMP>(sdr);
            return entity;
        }

        public bool UpdateResultLampEntity(RESULT_LAMP entity)
        {
            bool succ = false;
            PropertyInfo[] propertyInfos = entity.GetType().GetProperties();
            string strSql = "UPDATE RESULT_LAMP SET ";
            foreach (PropertyInfo p in propertyInfos)
            {
                if (p.Name != "ID" && p.Name != "JCLSH")
                {
                    strSql += string.Format("{0}='{1}',", p.Name, p.GetValue(entity, null));
                }
            }
            strSql = strSql.Substring(0, strSql.Length - 1);
            strSql += string.Format(" WHERE JCLSH ='{0}'", entity.JCLSH);
            int i = SqlHelper.ExcuteNonQuery(CommandType.Text, strSql);

            if (i > 0)
                succ = true;
            return succ;
        }
    }
}
