using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Disk Drive Data.
    /// </summary>
    public class DiskDriveInformation : Updatable, IUpdatable
    {
        public class DiskDrivePropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyCompressionMethod = "CompressionMethod";
            public readonly String gPropertyCreationClassName = "CreationClassName";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyFirmwareRevision = "FirmwareRevision";
            public readonly String gPropertyIndex = "Index";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyInterfaceType = "InterfaceType";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyModel = "Model";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPartitions = "Partitions";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertySCSIBus = "SCSIBus";
            public readonly String gPropertySCSILogicalUnit = "SCSILogicalUnit";
            public readonly String gPropertySCSIPort = "SCSIPort";
            public readonly String gPropertySCSITargetId = "SCSITargetId";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertySize = "Size";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertySystemCreationClassName = "SystemCreationClassName";
            public readonly String gPropertySystemName = "SystemName";
            public readonly String gPropertyTotalCylinders = "TotalCylinders";
            public readonly String gPropertyTotalHeads = "TotalHeads";
            public readonly String gPropertyTotalSectors = "TotalSectors";
            public readonly String gPropertyTotalTracks = "TotalTracks";
            public readonly String gPropertyTracksPerCylinder = "TracksPerCylinder";

            public string[] GetPropertyValues()
            {
                DiskDrivePropertyList propertyList = new DiskDrivePropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class DiskDrivePropertyData : AbstractPropertyData
        {
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyCompressionMethod;
            public String gPropertyCreationClassName;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyFirmwareRevision;
            public String gPropertyIndex;
            public String gPropertyInstallDate;
            public String gPropertyInterfaceType;
            public String gPropertyManufacturer;
            public String gPropertyModel;
            public String gPropertyName;
            public String gPropertyPartitions;
            public String gPropertyPNPDeviceID;
            public String gPropertySCSIBus;
            public String gPropertySCSILogicalUnit;
            public String gPropertySCSIPort;
            public String gPropertySCSITargetId;
            public String gPropertySerialNumber;
            public String gPropertySize;
            public String gPropertyStatus;
            public String gPropertySystemCreationClassName;
            public String gPropertySystemName;
            public String gPropertyTotalCylinders;
            public String gPropertyTotalHeads;
            public String gPropertyTotalSectors;
            public String gPropertyTotalTracks;
            public String gPropertyTracksPerCylinder;
        }

        public DiskDriveInformation() : base("SELECT * FROM Win32_DiskDrive")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new DiskDrivePropertyList(), new DiskDrivePropertyData());
        }
    }
}
