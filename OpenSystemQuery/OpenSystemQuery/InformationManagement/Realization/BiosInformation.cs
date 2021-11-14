using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores BIOS Data.
    /// </summary>
    public class BiosInformation : Updatable, IUpdatable
    {
        public class BiosPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyBIOSVersion = "BIOSVersion";
            public readonly String gPropertyBuildNumber = "BuildNumber";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertyVersion = "Version";

            public string[] GetPropertyValues()
            {
                BiosPropertyList propertyList = new BiosPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class BiosPropertyData : AbstractPropertyData
        {
            public String gPropertyBIOSVersion;
            public String gPropertyBuildNumber;
            public String gPropertyManufacturer;
            public String gPropertyName;
            public String gPropertySerialNumber;
            public String gPropertyVersion;
        }

        public BiosInformation() : base("SELECT * FROM Win32_BIOS")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new BiosPropertyList(), new BiosPropertyData());
        }
    }
}
