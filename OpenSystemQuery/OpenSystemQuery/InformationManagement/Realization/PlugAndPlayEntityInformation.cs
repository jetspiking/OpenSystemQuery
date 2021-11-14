using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores PnP-Entity Data.
    /// </summary>
    public class PlugAndPlayEntityInformation : Updatable, IUpdatable
    {
        public class PlugAndPlayEntityPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyClassGUID = "ClassGuid";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPClass = "PNPClass";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyService = "Service";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyStatusInfo = "StatusInfo";

            public string[] GetPropertyValues()
            {
                PlugAndPlayEntityPropertyList propertyList = new PlugAndPlayEntityPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class PlugAndPlayEntityPropertyData : AbstractPropertyData
        {
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyClassGUID;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyInstallDate;
            public String gPropertyManufacturer;
            public String gPropertyName;
            public String gPropertyPNPClass;
            public String gPropertyPNPDeviceID;
            public String gPropertyService;
            public String gPropertyStatus;
            public String gPropertyStatusInfo;
        }

        public PlugAndPlayEntityInformation() : base("SELECT * FROM Win32_PnPEntity")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new PlugAndPlayEntityPropertyList(), new PlugAndPlayEntityPropertyData());
        }
    }
}
