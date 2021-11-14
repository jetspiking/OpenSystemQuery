using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores LogicalDisk Data.
    /// </summary>
    public class LogicalDiskInformation : Updatable, IUpdatable
    {
        public class LogicalDiskPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAccess = "Access";
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyDriveType = "DriveType";
            public readonly String gPropertyFileSystem = "FileSystem";
            public readonly String gPropertyFreeSpace = "FreeSpace";
            public readonly String gPropertyMediaType = "MediaType";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyProviderName = "ProviderName";
            public readonly String gPropertySize = "Size";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyStatusInfo = "StatusInfo";
            public readonly String gPropertyVolumeName = "VolumeName";
            public readonly String gPropertyVolumeSerialNumber = "VolumeSerialNumber";

            public string[] GetPropertyValues()
            {
                LogicalDiskPropertyList propertyList = new LogicalDiskPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class LogicalDiskPropertyData : AbstractPropertyData
        {
            public String gPropertyAccess;
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyDriveType;
            public String gPropertyFileSystem;
            public String gPropertyFreeSpace;
            public String gPropertyMediaType;
            public String gPropertyName;
            public String gPropertyPNPDeviceID;
            public String gPropertyProviderName;
            public String gPropertySize;
            public String gPropertyStatus;
            public String gPropertyStatusInfo;
            public String gPropertyVolumeName;
            public String gPropertyVolumeSerialNumber;
        }

        public LogicalDiskInformation() : base("SELECT * FROM Win32_LogicalDisk")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new LogicalDiskPropertyList(), new LogicalDiskPropertyData());
        }
    }
}
