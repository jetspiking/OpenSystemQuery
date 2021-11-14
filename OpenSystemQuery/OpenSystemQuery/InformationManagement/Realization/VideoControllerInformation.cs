using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores GPU Data.
    /// </summary>
    public class VideoControllerInformation : Updatable, IUpdatable
    {
        public class VideoControllerPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAdapterCompatibility = "AdapterCompatibility";
            public readonly String gPropertyAdapterDACType = "AdapterDACType";
            public readonly String gPropertyAdapterRAM = "AdapterRAM";
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyDriverDate = "DriverDate";
            public readonly String gPropertyDriverVersion = "DriverVersion";
            public readonly String gPropertyInstalledDisplayDrivers = "InstalledDisplayDrivers";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyVideoModeDescription = "VideoModeDescription";
            public readonly String gPropertyVideoProcessor = "VideoProcessor";

            public string[] GetPropertyValues()
            {
                VideoControllerPropertyList propertyList = new VideoControllerPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class VideoControllerPropertyData : AbstractPropertyData
        {
            public String gPropertyAdapterCompatibility;
            public String gPropertyAdapterDACType;
            public String gPropertyAdapterRAM;
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertyDeviceID;
            public String gPropertyDriverDate;
            public String gPropertyDriverVersion;
            public String gPropertyInstalledDisplayDrivers;
            public String gPropertyName;
            public String gPropertyPNPDeviceID;
            public String gPropertyVideoModeDescription;
            public String gPropertyVideoProcessor;
        }

        public VideoControllerInformation() : base("SELECT * FROM Win32_VideoController")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new VideoControllerPropertyList(), new VideoControllerPropertyData());
        }
    }
}
