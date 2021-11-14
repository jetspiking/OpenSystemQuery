using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenSystemQuery.InformationManagement;

namespace OpenSystemQuery.Misc
{
    public static class AppContext
    {
        public static class Data
        {
            public static AbstractPropertyData[] baseBoardInformation;
            public static AbstractPropertyData[] batteryInformation;
            public static AbstractPropertyData[] biosInformation;
            public static AbstractPropertyData[] bootConfiguration;
            public static AbstractPropertyData[] busInformation;
            public static AbstractPropertyData[] diskDriveInformation;
            public static AbstractPropertyData[] fanInformation;
            public static AbstractPropertyData[] logicalDiskInformation;
            public static AbstractPropertyData[] networkAdapterInformation;
            public static AbstractPropertyData[] operatingSystemInformation;
            public static AbstractPropertyData[] physicalMemoryInformation;
            public static AbstractPropertyData[] plugAndPlayEntityInformation;
            public static AbstractPropertyData[] processInformation;
            public static AbstractPropertyData[] processorInformation;
            public static AbstractPropertyData[] temperatureProbeInformation;
            public static AbstractPropertyData[] videoControllerInformation;
            public static MainWindow mainWindow;
            public static Byte fontSize = 12;
            public static String dataToPrint = String.Empty;
            public static Stack<SystemActors> systemActorsHistory = new Stack<SystemActors>();
        }
    }
}
