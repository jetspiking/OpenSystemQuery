using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Fan Data.
    /// </summary>
    public class FanInformation : Updatable, IUpdatable
    {
        public class FanPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyActiveCooling = "ActiveCooling";
            public readonly String gPropertyAvailability = "Availability";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyConfigManagerErrorCode = "ErrorCode";
            public readonly String gPropertyConfigManagerUserConfig = "ConfigManagerUserConfig";
            public readonly String gPropertyCreationClassName = "CreationClassName";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDesiredSpeed = "DesiredSpeed";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyStatusInfo = "StatusInfo";
            public readonly String gPropertySystemCreationClassName = "SystemCreationClassName";
            public readonly String gPropertySystemName = "SystemName";
            public readonly String gPropertyVariableSpeed = "VariableSpeed";


            public string[] GetPropertyValues()
            {
                FanPropertyList propertyList = new FanPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class FanPropertyData : AbstractPropertyData
        {
            public String gPropertyActiveCooling;
            public String gPropertyAvailability;
            public String gPropertyCaption;
            public String gPropertyConfigManagerErrorCode;
            public String gPropertyConfigManagerUserConfig;
            public String gPropertyCreationClassName;
            public String gPropertyDescription;
            public String gPropertyDesiredSpeed;
            public String gPropertyDeviceID;
            public String gPropertyInstallDate;
            public String gPropertyName;
            public String gPropertyPNPDeviceID;
            public String gPropertyStatus;
            public String gPropertyStatusInfo;
            public String gPropertySystemCreationClassName;
            public String gPropertySystemName;
            public String gPropertyVariableSpeed;
        }

        public FanInformation() : base("SELECT * FROM Win32_Fan")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new FanPropertyList(), new FanPropertyData());
        }
    }
}
