using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Motherboard Data.
    /// </summary>
    public class BaseBoardInformation : Updatable, IUpdatable
    {
        public class BaseBoardPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyManufacturer = "Manufacturer";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyProduct = "Product";
            public readonly String gPropertySerialNumber = "SerialNumber";
            public readonly String gPropertySKU = "SKU";
            public readonly String gPropertySlotLayout = "SlotLayout";
            public readonly String gPropertySpecialRequirements = "SpecialRequirements";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyTag = "Tag";

            public string[] GetPropertyValues()
            {
                BaseBoardPropertyList propertyList = new BaseBoardPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class BaseBoardPropertyData : AbstractPropertyData
        {
            public String gPropertyDescription;
            public String gPropertyManufacturer;
            public String gPropertyName;
            public String gPropertyProduct;
            public String gPropertySerialNumber;
            public String gPropertySKU;
            public String gPropertySlotLayout;
            public String gPropertySpecialRequirements;
            public String gPropertyStatus;
            public String gPropertyTag;
        }

        public BaseBoardInformation() : base("SELECT * FROM Win32_BaseBoard")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new BaseBoardPropertyList(), new BaseBoardPropertyData());
        }
    }
}
