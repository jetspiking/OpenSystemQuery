using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Network Adapter Data.
    /// </summary>
    public class NetworkAdapterInformation : Updatable, IUpdatable
    {
        public class NetworkAdapterPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAdapterType = "AdapterType";
            public readonly String gPropertyAvailability = "Availability";            
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyGUID = "GUID";
            public readonly String gPropertyIndex = "Index";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyInterfaceIndex = "InterfaceIndex";
            public readonly String gPropertyMACAddress = "MACAddress";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyMaxSpeed = "MaxSpeed";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyNetConnectionID = "NetConnectionID";
            public readonly String gPropertyPermanentAddress = "PermanentAddress";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyProductName = "ProductName";
            public readonly String gPropertyServiceName = "ServiceName";
            public readonly String gPropertySpeed = "Speed";
            public readonly String gPropertyStatus = "Status";

            public string[] GetPropertyValues()
            {
                NetworkAdapterPropertyList propertyList = new NetworkAdapterPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class NetworkAdapterPropertyData : AbstractPropertyData
        {
            public String gPropertyAdapterType;
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyGUID;
            public String gPropertyIndex;
            public String gPropertyInstallDate;
            public String gPropertyInterfaceIndex;
            public String gPropertyMACAddress;
            public String gPropertyManufacturer;
            public String gPropertyMaxSpeed;
            public String gPropertyName;
            public String gPropertyNetConnectionID;
            public String gPropertyPermanentAddress;
            public String gPropertyPNPDeviceID;
            public String gPropertyProductName;
            public String gPropertyServiceName;
            public String gPropertySpeed;
            public String gPropertyStatus;
        }

        public NetworkAdapterInformation() : base("SELECT * FROM Win32_NetworkAdapter")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new NetworkAdapterPropertyList(), new NetworkAdapterPropertyData());
        }
    }
}
