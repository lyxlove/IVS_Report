using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UserTools
{
    public class EntityHelper
    {

        public static T FillEntity<T>(SqlDataReader reader)
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
