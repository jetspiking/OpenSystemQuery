using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Reflection;
using System.Diagnostics;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Abstract class which can be implemented to dynamically retrieve values from WMI-classes. 
    /// </summary>

    public abstract class Updatable
    {
        private String mMOSQuery { get; set; }

        public Updatable(String query)
        {
            this.mMOSQuery = query;
        }

        public AbstractPropertyData[] Update(PropertyProvider propertyProvider, AbstractPropertyData propertyData)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher(mMOSQuery);

            FieldInfo[] fieldInfo = propertyData.GetType().GetFields();
            String[] propertyList = ((IPropertyProvider)propertyProvider).GetPropertyValues();

            ManagementObjectCollection moc = mos.Get();
            AbstractPropertyData[] propertyArray = (AbstractPropertyData[])Array.CreateInstance(propertyData.GetType(), moc.Count);

            for (int mocIndex = 0; mocIndex < moc.Count; mocIndex++)
            {
                Object instance = Activator.CreateInstance(propertyData.GetType());
                ManagementObject mo = moc.OfType<ManagementObject>().ElementAt<ManagementObject>(mocIndex);
                foreach (PropertyData propertyReceivedData in mo.Properties)
                    for (int fieldIndex = 0; fieldIndex < propertyList.Length; fieldIndex++)
                        if (propertyList[fieldIndex] == propertyReceivedData.Name.ToString())
                            if (propertyReceivedData.Value != null)
                                fieldInfo[fieldIndex].SetValue(instance, propertyReceivedData.Value.ToString());
                propertyArray[mocIndex] = (AbstractPropertyData)instance;
            }

            return propertyArray;
        }
    }
}

