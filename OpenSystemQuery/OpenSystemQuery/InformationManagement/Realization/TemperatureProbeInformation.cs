using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Temperature Probe Data.
    /// </summary>
    public class TemperatureProbeInformation : Updatable, IUpdatable
    {
        public class TemperatureProbePropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyAccuracy = "Accuracy";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyCurrentReading = "CurrentReading";
            public readonly String gPropertyDeviceID = "DeviceID";
            public readonly String gPropertyLowerThresholdCritical = "LowerThresholdCritical";
            public readonly String gPropertyLowerThresholdFatal = "LowerThresholdFatal";
            public readonly String gPropertyLowerThresholdNonCritical = "LowerThresholdNonCritical";
            public readonly String gPropertyMaxReadable = "MaxReadable";
            public readonly String gPropertyMinReadable = "MinReadable";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyNominalReading = "NominalReading";
            public readonly String gPropertyNormalMax = "NormalMax";
            public readonly String gPropertyNormalMin = "NormalMin";
            public readonly String gPropertyPNPDeviceID = "PNPDeviceID";
            public readonly String gPropertyResolution = "Resolution";
            public readonly String gPropertyTolerance = "Tolerance";
            public readonly String gPropertyUpperThresholdCritical = "UpperThresholdCritical";
            public readonly String gPropertyUpperThresholdFatal = "UpperThresholdFatal";
            public readonly String gPropertyUpperThresholdNonCritical = "UpperThresholdNonCritical";

            public string[] GetPropertyValues()
            {
                TemperatureProbePropertyList propertyList = new TemperatureProbePropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }


        public class TemperatureProbePropertyData : AbstractPropertyData
        {
            public String gPropertyAccuracy;
            public String gPropertyCaption;
            public String gPropertyDescription;
            public String gPropertyCurrentReading;
            public String gPropertyDeviceID;
            public String gPropertyLowerThresholdCritical;
            public String gPropertyLowerThresholdFatal;
            public String gPropertyLowerThresholdNonCritical;
            public String gPropertyMaxReadable;
            public String gPropertyMinReadable;
            public String gPropertyName;
            public String gPropertyNominalReading;
            public String gPropertyNormalMax;
            public String gPropertyNormalMin;
            public String gPropertyPNPDeviceID;
            public String gPropertyResolution;
            public String gPropertyTolerance;
            public String gPropertyUpperThresholdCritical;
            public String gPropertyUpperThresholdFatal;
            public String gPropertyUpperThresholdNonCritical;
        }

        public TemperatureProbeInformation() : base("SELECT * FROM Win32_TemperatureProbe")
        {
              
        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new TemperatureProbePropertyList(), new TemperatureProbePropertyData());
        }
    }
}
