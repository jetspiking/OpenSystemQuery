using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Boot Configuration Data.
    /// </summary>
    public class BootConfigurationInformation : Updatable, IUpdatable
    {
        public class BootConfigurationPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertySettingID = "SettingId";
            public readonly String gPropertyBootDirectory = "BootDirectory";
            public readonly String gPropertyConfigurationPath = "ConfigurationPath";
            public readonly String gPropertyLastDrive = "LastDrive";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyScratchDirectory = "ScratchDirectory";
            public readonly String gPropertyTempDirectory = "TempDirectory";

            public string[] GetPropertyValues()
            {
                BootConfigurationPropertyList propertyList = new BootConfigurationPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class BootConfigurationPropertyData : AbstractPropertyData
        {
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertySettingID;
            public String gPropertyBootDirectory;
            public String gPropertyConfigurationPath;
            public String gPropertyLastDrive;
            public String gPropertyName;
            public String gPropertyScratchDirectory;
            public String gPropertyTempDirectory;
        }

        public BootConfigurationInformation() : base("SELECT * FROM Win32_BootConfiguration")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new BootConfigurationPropertyList(), new BootConfigurationPropertyData());
        }
    }
}
