using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;
using UserTools;
using System.Reflection;

namespace DAL
{
    public class RESULT_VEHICLE_INFO_DAL
    {

        public List<RESULT_VEHICLE_INFO> GetResultVehicleList()
        {
            List<RESULT_VEHICLE_INFO> list = new List<RESULT_VEHICLE_INFO>();

            SqlDataReader sdr = SqlHelper.ExecuteReader(CommandType.Text, "SELECT TOP 10 *  FROM  RESULT_VEHICLE_INFO");
            while (sdr.Read())
            {
                RESULT_VEHICLE_INFO enity = new RESULT_VEHICLE_INFO();
                enity.JCLSH = (string)sdr["JCLSH"];
                list.Add(enity);
            }
            return list;
        }

        public DataSet GetVehicleResultDataSet()
        {
            DataSet dt = new DataSet();
            dt = SqlHelper.ExecuteDataset(SqlHelper.ConnectStr, CommandType.Text, "SELECT TOP 10 ID,JCLSH AS '检测流水号',HPHM AS '号牌号码'  FROM  RESULT_VEHICLE_INFO WHERE JCXH = '3' ORDER BY ID DESC");
            return dt;
        }

        public RESULT_VEHICLE_INFO GetResultVehicleInfoByJCLSH(string strJCLSH)
        {
            SqlDataReader sdr = SqlHelper.ExecuteReader(CommandType.Text, string.Format("SELECT  *  FROM  RESULT_VEHICLE_INFO WHERE JCLSH = '{0}'", strJCLSH));
            RESULT_VEHICLE_INFO entity = FillEntity<RESULT_VEHICLE_INFO>(sdr);
            return entity;
        }

        public void UpdateResultVehicleInfo(RESULT_VEHICLE_INFO entity)
        {
            PropertyInfo[] propertyInfos = entity.GetType().GetProperties();
            string strSql = "UPDATE RESULT_VEHICLE_INFO SET ";
            foreach(PropertyInfo p in propertyInfos)
            {
                if (p.Name != "ID" && p.Name != "JCLSH")
                {
                    strSql += string.Format("{0}='{1}',", p.Name, p.GetValue(entity, null));
                }
            }
            strSql = strSql.Substring(0, strSql.Length - 1);
            strSql += string.Format(" WHERE JCLSH ='{0}'", entity.JCLSH);
            SqlHelper.ExcuteNonQuery(CommandType.Text, strSql);
            
        }




        public T FillEntity<T>(SqlDataReader reader)
        {
            try
            {

                using (reader)
                {
                    if (reader.Read())
                    {
                        Type type = typeof(T);
                        T entity = Activator.CreateInstance<T>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader[i] != DBNull.Value)
                            {
                                PropertyInfo propertyInfo = type.GetProperty(reader.GetName(i));
                                propertyInfo.SetValue(entity, HackType(reader[i], propertyInfo.PropertyType), null);
                            }


                        }
                        return entity;
                    }
                }
                return default(T);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private static object HackType(object value, Type conversionType)
        {

            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }
                System.ComponentModel.NullableConverter nullAbleConverter = new System.ComponentModel.NullableConverter(conversionType);
                conversionType = nullAbleConverter.UnderlyingType;
            }
            return Convert.ChangeType(value, conversionType);
        }

    }
}
