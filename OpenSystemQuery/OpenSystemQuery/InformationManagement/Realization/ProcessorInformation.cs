using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Processor Data.
    /// </summary>
    public class ProcessorInformation : Updatable, IUpdatable
    {
        public class ProcessorPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAddressWidth = "AddressWidth";
            public readonly String gPropertyArchitecture = "Architecture";
            public readonly String gPropertyAssetTag = "AssetTag";
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyCharacteristics = "Characteristics";
            public readonly String gPropertyConfigManagerErrorCode = "ConfigManagerErrorCode";
            public readonly String gPropertyConfigManagerUserConfig = "ConfigManagerUserConfig";
            public readonly String gPropertyCpuStatus = "CpuStatus";
            public readonly String gPropertyCreationClassName = "CreationClassName";
            public readonly String gPropertyCurrentClockSpeed = "CurrentClockSpeed";
            public readonly String gPropertyCurrentVoltage = "CurrentVoltage";
            public readonly String gPropertyDataWidth = "DataWidth";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyErrorCleared = "ErrorCleared";
            public readonly String gPropertyErrorDescription = "ErrorDescription";
            public readonly String gPropertyExternalClock = "ExtClock";
            public readonly String gPropertyFamily = "Family";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyL2CacheSize = "L2CacheSize";
            public readonly String gPropertyL2CacheSpeed = "L2CacheSpeed";
            public readonly String gPropertyL3CacheSize = "L3CacheSize";
            public readonly String gPropertyL3CacheSpeed = "L3CacheSpeed";
            public readonly String gPropertyLastErrorCode = "LastErrorCode";
            public readonly String gPropertyLevel = "Level";
            public readonly String gPropertyLoadPercentage = "LoadPercentage";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyMaxClockSpeed = "MaxClockSpeed";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyNumberOfCores = "NumberOfCores";
            public readonly String gPropertyNumberOfEnabledCores = "NumberOfEnabledCore";
            public readonly String gPropertyNumberOfLogicalProcessors = "NumberOfLogicalProcessors";
            public readonly String gPropertyOtherFamilyDescription = "OtherFamilyDescription";
            public readonly String gPropertyPartNumber = "PartNumber";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyPowerManagementCapabilities = "PowerManagementCapabilities";
            public readonly String gPropertyPowerManagementSupported = "PowerManagementSupported";
            public readonly String gPropertyProcessorID = "ProcessorId";
            public readonly String gPropertyProcessorType = "ProcessorType";
            public readonly String gPropertyRevision = "Revision";
            public readonly String gPropertyRole = "Role";
            public readonly String gPropertySecondLevelAddressTranslationExtensions = "SecondLevelAddressTranslationExtensions";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertySocketDesignation = "SocketDesignation";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyStatusInfo = "StatusInfo";
            public readonly String gPropertyStepping = "Stepping";
            public readonly String gPropertySystemCreationClassName = "SystemCreationClassName";
            public readonly String gPropertySystemName = "SystemName";
            public readonly String gPropertyThreadCount = "ThreadCount";
            public readonly String gPropertyUniqueID = "UniqueId";
            public readonly String gPropertyUpgradeMethod = "UpgradeMethod";
            public readonly String gPropertyVersion = "Version";
            public readonly String gPropertyVirtualizationFirmwareEnabled = "VirtualizationFirmwareEnabled";
            public readonly String gPropertyVMMonitorModeExtensions = "VMMonitorExtensions";
            public readonly String gPropertyVoltageCaps = "VoltageCaps";

            public string[] GetPropertyValues()
            {
                ProcessorPropertyList propertyList = new ProcessorPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class ProcessorPropertyData : AbstractPropertyData
        {
            public String gPropertyAddressWidth;
            public String gPropertyArchitecture;
            public String gPropertyAssetTag;
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyCharacteristics;
            public String gPropertyConfigManagerErrorCode;
            public String gPropertyConfigManagerUserConfig;
            public String gPropertyCpuStatus;
            public String gPropertyCreationClassName;
            public String gPropertyCurrentClockSpeed;
            public String gPropertyCurrentVoltage;
            public String gPropertyDataWidth;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyErrorCleared;
            public String gPropertyErrorDescription;
            public String gPropertyExternalClock;
            public String gPropertyFamily;
            public String gPropertyInstallDate;
            public String gPropertyL2CacheSize;
            public String gPropertyL2CacheSpeed;
            public String gPropertyL3CacheSize;
            public String gPropertyL3CacheSpeed;
            public String gPropertyLastErrorCode;
            public String gPropertyLevel;
            public String gPropertyLoadPercentage;
            public String gPropertyManufacturer;
            public String gPropertyMaxClockSpeed;
            public String gPropertyName;
            public String gPropertyNumberOfCores;
            public String gPropertyNumberOfEnabledCores;
            public String gPropertyNumberOfLogicalProcessors;
            public String gPropertyOtherFamilyDescription;
            public String gPropertyPartNumber;
            public String gPropertyPNPDeviceID;
            public String gPropertyPowerManagementCapabilities;
            public String gPropertyPowerManagementSupported;
            public String gPropertyProcessorID;
            public String gPropertyProcessorType;
            public String gPropertyRevision;
            public String gPropertyRole;
            public String gPropertySecondLevelAddressTranslationExtensions;
            public String gPropertySerialNumber;
            public String gPropertySocketDesignation;
            public String gPropertyStatus;
            public String gPropertyStatusInfo;
            public String gPropertyStepping;
            public String gPropertySystemCreationClassName;
            public String gPropertySystemName;
            public String gPropertyThreadCount;
            public String gPropertyUniqueID;
            public String gPropertyUpgradeMethod;
            public String gPropertyVersion;
            public String gPropertyVirtualizationFirmwareEnabled;
            public String gPropertyVMMonitorModeExtensions;
            public String gPropertyVoltageCaps;
        }

        public ProcessorInformation() : base("SELECT * FROM Win32_Processor")
        {
              
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new ProcessorPropertyList(), new ProcessorPropertyData());
        }
    }
}
