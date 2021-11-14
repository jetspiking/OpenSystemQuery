using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Memory Data.
    /// </summary>
    public class PhysicalMemoryInformation : Updatable, IUpdatable
    {
        public class PhysicalMemoryPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAttributes = "Attributes";
            public readonly String gPropertyBankLabel = "BankLabel";
            public readonly String gPropertyCapacity = "Capacity";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyConfiguredClockSpeed = "ConfiguredClockSpeed";
            public readonly String gPropertyConfiguredVoltage = "Voltage";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDeviceLocator = "DeviceLocator";
            public readonly String gPropertyFormFactor = "FormFactor";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyMaxVoltage = "MaxVoltage";
            public readonly String gPropertyMemoryType = "MemoryType";
            public readonly String gPropertyMinVoltage = "MinVoltage";
            public readonly String gPropertyModel = "Model";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyOtherIdentifyingInfo = "OtherIdentifyingInfo";
            public readonly String gPropertyPartNumber = "PartNumber";
            public readonly String gPropertyPositionInRow = "PositionInRow";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertySKU = "SKU";
            public readonly String gPropertyTag = "Tag";
            public readonly String gPropertySpeed = "Speed";
            public readonly String gPropertyVersion = "Version";

            public string[] GetPropertyValues()
            {
                PhysicalMemoryPropertyList propertyList = new PhysicalMemoryPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class PhysicalMemoryPropertyData : AbstractPropertyData
        {
            public String gPropertyAttributes;
            public String gPropertyBankLabel;
            public String gPropertyCapacity;
            public String gPropertyCaption;
            public String gPropertyConfiguredClockSpeed;
            public String gPropertyConfiguredVoltage;
            public String gPropertyDescription;
            public String gPropertyDeviceLocator;
            public String gPropertyFormFactor;
            public String gPropertyManufacturer;
            public String gPropertyMaxVoltage;
            public String gPropertyMemoryType;
            public String gPropertyMinVoltage;
            public String gPropertyModel;
            public String gPropertyName;
            public String gPropertyOtherIdentifyingInfo;
            public String gPropertyPartNumber;
            public String gPropertyPositionInRow;
            public String gPropertySerialNumber;
            public String gPropertySKU;
            public String gPropertyTag;
            public String gPropertySpeed;
            public String gPropertyVersion;
        }

        public PhysicalMemoryInformation() : base("SELECT * FROM Win32_PhysicalMemory")
        {
              
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new PhysicalMemoryPropertyList(), new PhysicalMemoryPropertyData());
        }
    }
}
