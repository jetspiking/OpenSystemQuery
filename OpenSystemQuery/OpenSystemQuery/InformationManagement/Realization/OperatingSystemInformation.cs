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
    /// Stores OS Data.
    /// </summary>
    public class OperatingSystemInformation : Updatable, IUpdatable
    {
        public class OperatingSystemPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyBootDevice = "BootDevice";
            public readonly String gPropertyBuildNumber = "BuildNumber";
            public readonly String gPropertyBuildType = "BuildType";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyCodeSet = "CodeSet";
            public readonly String gPropertyCountryCode = "CountryCode";
            public readonly String gPropertyCreationClassName = "CreationClassName";
            public readonly String gPropertyCSCreationClassName = "CSCreationClassName";
            public readonly String gPropertyCSDVersion = "CSDVersion";
            public readonly String gPropertyCSName = "CSName";
            public readonly String gPropertyCurrentTimeZone = "CurrentTimeZone";
            public readonly String gPropertyDataExecutionPreventionAvailable = "DataExecutionPrevention_Available";
            public readonly String gPropertyDataExecutionPrevention32BitApplications = "DataExecutionPrevention_32BitApplications";
            public readonly String gPropertyDataExecutionPreventionDrivers = "DataExecutionPrevention_Drivers";
            public readonly String gPropertyDataExecutionPreventionSupportPolicy = "DataExecutionPrevention_SupportPolicy";
            public readonly String gPropertyDebug = "Debug";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDistributed = "Distributed";
            public readonly String gPropertyEncryptionLevel = "EncryptionLevel";
            public readonly String gPropertyForegroundApplicationBoost = "ForegroundApplicationBoost";
            public readonly String gPropertyFreePhysicalMemory = "FreePhysicalMemory";
            public readonly String gPropertyFreeSpaceInPagingFiles = "FreeSpaceInPagingFiles";
            public readonly String gPropertyFreeVirtualMemory = "FreeVirtualMemory";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyLargeSystemCache = "LargeSystemCache";
            public readonly String gPropertyLastBootUpTime = "LastBootUpTime";
            public readonly String gPropertyLocalDateTime = "LocalDateTime";
            public readonly String gPropertyLocale = "Locale";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyMaxNumberOfProcesses = "MaxNumberOfProcesses";
            public readonly String gPropertyMaxProcessMemorySize = "MaxProcessMemorySize";
            public readonly String gPropertyMUILanguages = "MUILanguages";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyNumberOfLicensedUsers = "NumberOfLicensedUsers";
            public readonly String gPropertyNumberOfProcesses = "NumberOfProcesses";
            public readonly String gPropertyNumberOfUsers = "NumberOfUsers";
            public readonly String gPropertyOperatingSystemSKU = "OperatingSystemSKU";
            public readonly String gPropertyOrganization = "Organization";
            public readonly String gPropertyOSArchitecture = "OSArchitecture";
            public readonly String gPropertyOSLanguage = "OSLanguage";
            public readonly String gPropertyOSProductSuite = "OSProductSuite";
            public readonly String gPropertyOSType = "OSType";
            public readonly String gPropertyOtherTypeDescription = "OtherTypeDescription";
            public readonly String gPropertyPAEEnabled = "PAEEnabled";
            public readonly String gPropertyPlusProductID = "PlusProductID";
            public readonly String gPropertyPlusVersionNumber = "PlusVersionNumber";
            public readonly String gPropertyPortableOperatingSystem = "PortableOperatingSystem";
            public readonly String gPropertyPrimary = "Primary";
            public readonly String gPropertyProductType = "ProductType";
            public readonly String gPropertyRegisteredUser = "RegisteredUser";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertyServicePackMajorVersion = "ServicePackMajorVersion";
            public readonly String gPropertyServicePackMinorVersion = "ServicePackMinorVersion";
            public readonly String gPropertySizeStoredInPagingFiles = "SizeStoredInPagingFiles";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertySuiteMask = "SuiteMask";
            public readonly String gPropertySystemDevice = "SystemDevice";
            public readonly String gPropertySystemDirectory = "SystemDirectory";
            public readonly String gPropertySystemDrive = "SystemDrive";
            public readonly String gPropertyTotalSwapSpaceSize = "TotalSwapSpaceSize";
            public readonly String gPropertyTotalVirtualMemorySize = "TotalVirtualMemorySize";
            public readonly String gPropertyTotalVisibleMemorySize = "TotalVisibleMemorySize";
            public readonly String gPropertyVersion = "Version";
            public readonly String gPropertyWindowsDirectory = "WindowsDirectory";
            public readonly String gPropertyQuantumLength = "QuantumLength";
            public readonly String gPropertyQuantumType = "QuantumType";

            public string[] GetPropertyValues()
            {
                OperatingSystemPropertyList propertyList = new OperatingSystemPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class OperatingSystemPropertyData : AbstractPropertyData
        {
            public String gPropertyBootDevice;
            public String gPropertyBuildNumber;
            public String gPropertyBuildType;
            public String gPropertyCaption;
            public String gPropertyCodeSet;
            public String gPropertyCountryCode;
            public String gPropertyCreationClassName;
            public String gPropertyCSCreationClassName;
            public String gPropertyCSDVersion;
            public String gPropertyCSName;
            public String gPropertyCurrentTimeZone;
            public String gPropertyDataExecutionPreventionAvailable;
            public String gPropertyDataExecutionPrevention32BitApplications;
            public String gPropertyDataExecutionPreventionDrivers;
            public String gPropertyDataExecutionPreventionSupportPolicy;
            public String gPropertyDebug;
            public String gPropertyDescription;
            public String gPropertyDistributed;
            public String gPropertyEncryptionLevel;
            public String gPropertyForegroundApplicationBoost;
            public String gPropertyFreePhysicalMemory;
            public String gPropertyFreeSpaceInPagingFiles;
            public String gPropertyFreeVirtualMemory;
            public String gPropertyInstallDate;
            public String gPropertyLargeSystemCache;
            public String gPropertyLastBootUpTime;
            public String gPropertyLocalDateTime;
            public String gPropertyLocale;
            public String gPropertyManufacturer;
            public String gPropertyMaxNumberOfProcesses;
            public String gPropertyMaxProcessMemorySize;
            public String gPropertyMUILanguages;
            public String gPropertyName;
            public String gPropertyNumberOfLicensedUsers;
            public String gPropertyNumberOfProcesses;
            public String gPropertyNumberOfUsers;
            public String gPropertyOperatingSystemSKU;
            public String gPropertyOrganization;
            public String gPropertyOSArchitecture;
            public String gPropertyOSLanguage;
            public String gPropertyOSProductSuite;
            public String gPropertyOSType;
            public String gPropertyOtherTypeDescription;
            public String gPropertyPAEEnabled;
            public String gPropertyPlusProductID;
            public String gPropertyPlusVersionNumber;
            public String gPropertyPortableOperatingSystem;
            public String gPropertyPrimary;
            public String gPropertyProductType;
            public String gPropertyRegisteredUser;
            public String gPropertySerialNumber;
            public String gPropertyServicePackMajorVersion;
            public String gPropertyServicePackMinorVersion;
            public String gPropertySizeStoredInPagingFiles;
            public String gPropertyStatus;
            public String gPropertySuiteMask;
            public String gPropertySystemDevice;
            public String gPropertySystemDirectory;
            public String gPropertySystemDrive;
            public String gPropertyTotalSwapSpaceSize;
            public String gPropertyTotalVirtualMemorySize;
            public String gPropertyTotalVisibleMemorySize;
            public String gPropertyVersion;
            public String gPropertyWindowsDirectory;
            public String gPropertyQuantumLength;
            public String gPropertyQuantumType;
        }

        public OperatingSystemInformation() : base("SELECT * FROM Win32_OperatingSystem")
        {
            
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new OperatingSystemPropertyList(),new OperatingSystemPropertyData());
        }
    }
}
