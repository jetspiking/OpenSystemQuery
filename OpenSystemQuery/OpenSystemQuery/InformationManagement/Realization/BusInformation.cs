using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Bus Data.
    /// </summary>
    public class BusInformation : Updatable, IUpdatable
    {
        public class BusPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyBusNum = "BusNum";
            public readonly String gPropertyBusType = "BusType";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";

            public string[] GetPropertyValues()
            {
                BusPropertyList propertyList = new BusPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class BusPropertyData : AbstractPropertyData
        {
            public String gPropertyBusNum;
            public String gPropertyBusType;
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyName;
            public String gPropertyPNPDeviceID;
        }

        public BusInformation() : base("SELECT * FROM Win32_Bus")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new BusPropertyList(), new BusPropertyData());
        }
    }
}
