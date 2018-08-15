using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UserTools
{
    public class ObjectFactory
    {

        public static T CreateObject<T>()
        {            
            Assembly assembly = Assembly.Load("BLL");
            Type type = assembly.GetType("BLL."+typeof(T).Name.Substring(1),false);
            return (T)Activator.CreateInstance(type);
        }

    }
}
