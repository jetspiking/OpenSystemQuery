using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Battery Data.
    /// </summary>
    public class BatteryInformation : Updatable, IUpdatable
    {
        public class BatteryPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyBatteryRechargeTime = "BatteryRechargeTime";
            public readonly String gPropertyBatteryStatus = "BatteryStatus";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyChemistry = "Chemistry";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyDesignCapacity = "DesignCapacity";
            public readonly String gPropertyDesignVoltage = "DesignVoltage";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyEstimatedChargeRemaining = "EstimatedChargeRemaining";
            public readonly String gPropertyEstimatedRunTime = "EstimatedRunTime";
            public readonly String gPropertyExpectedBatteryLife = "ExpectedBatteryLife";
            public readonly String gPropertyExpectedLife = "ExpectedLife";
            public readonly String gPropertyFullChargeCapacity = "FullChargeCapacity";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyMaxRechargeTime = "MaxRechargeTime";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertySmartBatteryVersion = "SmartBatteryVersion";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyTimeOnBattery = "TimeOnBattery";
            public readonly String gPropertyTimeToFullCharge = "TimeToFullCharge"; 

            public string[] GetPropertyValues()
            {
                BatteryPropertyList propertyList = new BatteryPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class BatteryPropertyData : AbstractPropertyData
        {
            public String gPropertyBatteryRechargeTime;
            public String gPropertyBatteryStatus;
            public String gPropertyCaption;
            public String gPropertyChemistry;
            public String gPropertyDescription;
            public String gPropertyDesignCapacity;
            public String gPropertyDesignVoltage;
            public String gPropertyDeviceID;
            public String gPropertyEstimatedChargeRemaining;
            public String gPropertyEstimatedRunTime;
            public String gPropertyExpectedBatteryLife;
            public String gPropertyExpectedLife;
            public String gPropertyFullChargeCapacity;
            public String gPropertyInstallDate;
            public String gPropertyMaxRechargeTime;
            public String gPropertyName;
            public String gPropertyPNPDeviceID;
            public String gPropertySmartBatteryVersion;
            public String gPropertyStatus;
            public String gPropertyTimeOnBattery;
            public String gPropertyTimeToFullCharge;
        }

        public BatteryInformation() : base("SELECT * FROM Win32_Battery")
        {
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new BatteryPropertyList(), new BatteryPropertyData());
        }
    }
}
