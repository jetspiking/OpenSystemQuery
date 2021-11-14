using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Class that can be implemented to provide an implementation to receive property values.
    /// </summary>
    /// 
    public class PropertyProvider
    {
        public String[] GetPropertyValues(IPropertyProvider propertyProvider)
        {
            FieldInfo[] fieldInfo = propertyProvider.GetType().GetFields();
            Object instance = Activator.CreateInstance(propertyProvider.GetType());
            String[] returnValues = new String[fieldInfo.Length];
            for (int fieldIndex = 0; fieldIndex < fieldInfo.Length; fieldIndex++)
                returnValues[fieldIndex] = fieldInfo[fieldIndex].GetValue(instance).ToString();
            return returnValues;
        }
    }
}
