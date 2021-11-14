using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using OpenSystemQuery.Misc;
using OpenSystemQuery.InformationManagement;
using System.Reflection;

namespace OpenSystemQuery.Views
{
    public class ContainerView : IViewProvider
    {
        public StackPanel gStackPanel = new StackPanel();
        public SystemActors mSystemActor;

        public ContainerView(SystemActors systemActor)
        {
            mSystemActor = systemActor;
            CreateView();
        }

        public void Update()
        {
            gStackPanel.Children.Clear();
            CreateView();
        }

        private void CreateView()
        {
            switch (mSystemActor)
            {
                case SystemActors.System:
                    BuildSystemView();
                    break;
                case SystemActors.Processor:
                    BuildProcessorView();
                    break;
                case SystemActors.Motherboard:
                    BuildMotherboardView();
                    break;
                case SystemActors.Memory:
                    BuildMemoryView();
                    break;
                case SystemActors.VideoAdapter:
                    BuildGraphicsView();
                    break;
                case SystemActors.PnPEntity:
                    BuildPlugAndPlayView();
                    break;
                case SystemActors.Drives:
                    BuildDiskDrivesView();
                    break;
                case SystemActors.Fans:
                    BuildFanView();
                    break;
                case SystemActors.Bus:
                    BuildBusView();
                    break;
                case SystemActors.Process:
                    BuildProcessView();
                    break;
            }
            AppContext.Data.systemActorsHistory.Push(mSystemActor);
        }

        private void BuildSystemView()
        {
            String data = String.Empty;

            foreach (OperatingSystemInformation.OperatingSystemPropertyData operatingSystemPropertyData in (OperatingSystemInformation.OperatingSystemPropertyData[])AppContext.Data.operatingSystemInformation)
            {
                data += "-------------------\n";
                data += "System Name: " + operatingSystemPropertyData.gPropertyCSName + "\n\n";
                data += "OS Build Number: " + operatingSystemPropertyData.gPropertyBuildNumber + "\n";
                data += "OS Version: " + operatingSystemPropertyData.gPropertyVersion + "\n";
                data += "OS Serial Number: " + operatingSystemPropertyData.gPropertySerialNumber + "\n";
                data += "OS Manufacturer: " + operatingSystemPropertyData.gPropertyManufacturer + "\n";
                data += "OS Architecture: " + operatingSystemPropertyData.gPropertyOSArchitecture + "\n";
                data += "OS Language: " + operatingSystemPropertyData.gPropertyOSLanguage + "\n\n";
                data += "Boot Device: " + operatingSystemPropertyData.gPropertyBootDevice + "\n";
                data += "Organization: " + operatingSystemPropertyData.gPropertyOrganization + "\n";
                data += "Time Zone: " + operatingSystemPropertyData.gPropertyCurrentTimeZone + "\n";
                data += "Country Code: " + operatingSystemPropertyData.gPropertyCountryCode + "\n\n";
                data += "Status: " + operatingSystemPropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label systemInformation = new Label();
            systemInformation.FontSize = AppContext.Data.fontSize;
            systemInformation.Content = data;
            gStackPanel.Children.Add(systemInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildProcessorView()
        {
            String data = String.Empty;

            foreach (ProcessorInformation.ProcessorPropertyData processorPropertyData in (ProcessorInformation.ProcessorPropertyData[])AppContext.Data.processorInformation)
            {
                data += "-------------------\n";
                data += "Processor: " + processorPropertyData.gPropertyName + "\n";
                data += "Manufacturer: " + processorPropertyData.gPropertyManufacturer + "\n\n";
                data += "Logical Processors: " + processorPropertyData.gPropertyNumberOfLogicalProcessors + "\n";
                data += "Cores: " + processorPropertyData.gPropertyNumberOfCores + "\n";
                data += "Thread Count: " + processorPropertyData.gPropertyThreadCount + "\n\n";              
                data += "Current Clock Speed: " + processorPropertyData.gPropertyCurrentClockSpeed + "\n";
                data += "Max Clock Speed: "+ processorPropertyData.gPropertyMaxClockSpeed + "\n";
                data += "Currrent Voltage: " + processorPropertyData.gPropertyCurrentVoltage + "\n\n";
                data += "Family: " + processorPropertyData.gPropertyFamily + "\n\n";
                data += "Stepping: " + processorPropertyData.gPropertyStepping + "\n";
                data += "Part Number: " + processorPropertyData.gPropertyPartNumber + "\n";
                data += "CPU Status: " + processorPropertyData.gPropertyCpuStatus + "\n";
                data += "Characteristics: " + processorPropertyData.gPropertyCharacteristics + "\n";
                data += "L2 Cache Size: " + processorPropertyData.gPropertyL2CacheSize + "\n";
                data += "L2 Cache Speed: " + processorPropertyData.gPropertyL2CacheSpeed + "\n";
                data += "L3 Cache Size: " + processorPropertyData.gPropertyL3CacheSize + "\n";
                data += "L3 Cache Speed: " + processorPropertyData.gPropertyL3CacheSpeed + "\n\n";
                data += "Load Percentage: " + processorPropertyData.gPropertyLoadPercentage + "\n";
                data += "Processor ID: " + processorPropertyData.gPropertyProcessorID + "\n";
                data += "Processor Type: " + processorPropertyData.gPropertyProcessorType + "\n";
                data += "Socket Designation: " + processorPropertyData.gPropertySocketDesignation + "\n\n";
                data += "Status: " + processorPropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label processorInformation = new Label();
            processorInformation.FontSize = AppContext.Data.fontSize;
            processorInformation.Content = data;
            gStackPanel.Children.Add(processorInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildMotherboardView()
        {
            String data = String.Empty;

            foreach (BaseBoardInformation.BaseBoardPropertyData baseBoardPropertyData in (BaseBoardInformation.BaseBoardPropertyData[])AppContext.Data.baseBoardInformation)
            {
                data += "-------------------\n";
                data += "Motherboard: " + baseBoardPropertyData.gPropertyName + "\n";
                data += "Manufacturer: " + baseBoardPropertyData.gPropertyManufacturer + "\n\n";
                data += "Product: " + baseBoardPropertyData.gPropertyProduct + "\n";
                data += "Tag: " + baseBoardPropertyData.gPropertyTag + "\n";
                data += "Serial Number: " + baseBoardPropertyData.gPropertySerialNumber + "\n";
                data += "SKU: " + baseBoardPropertyData.gPropertySKU + "\n\n";
                data += "Slot Layout: " + baseBoardPropertyData.gPropertySlotLayout + "\n";
                data += "Special Requirements: " + baseBoardPropertyData.gPropertySpecialRequirements + "\n\n";
                data += "Status: " + baseBoardPropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label processorInformation = new Label();
            processorInformation.FontSize = AppContext.Data.fontSize;
            processorInformation.Content = data;
            gStackPanel.Children.Add(processorInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildMemoryView()
        {
            String data = String.Empty;

            foreach (PhysicalMemoryInformation.PhysicalMemoryPropertyData physicalMemoryPropertyData in (PhysicalMemoryInformation.PhysicalMemoryPropertyData[])AppContext.Data.physicalMemoryInformation)
            {
                data += "-------------------\n";
                data += "Name: " + physicalMemoryPropertyData.gPropertyName + "\n";
                data += "Manufacturer: " + physicalMemoryPropertyData.gPropertyManufacturer + "\n\n";
                data += "Model: " + physicalMemoryPropertyData.gPropertyModel + "\n";
                data += "Serial Number: " + physicalMemoryPropertyData.gPropertySerialNumber + "\n";
                data += "SKU: " + physicalMemoryPropertyData.gPropertySKU + "\n\n";
                data += "Speed: "+ physicalMemoryPropertyData.gPropertySpeed + "\n";
                data += "Clock Speed: " + physicalMemoryPropertyData.gPropertyConfiguredClockSpeed + "\n\n";
                data += "Voltage: " + physicalMemoryPropertyData.gPropertyConfiguredVoltage + "\n";
                data += "Minimum voltage: " + physicalMemoryPropertyData.gPropertyMinVoltage + "\n";
                data += "Maximum voltage: " + physicalMemoryPropertyData.gPropertyMinVoltage + "\n\n";
                data += "Capacity: " + physicalMemoryPropertyData.gPropertyCapacity + "\n";
                data += "Attributes: " + physicalMemoryPropertyData.gPropertyAttributes + "\n";
                data += "-------------------\n\n";
            }

            Label memoryInformation = new Label();
            memoryInformation.FontSize = AppContext.Data.fontSize;
            memoryInformation.Content = data;
            gStackPanel.Children.Add(memoryInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildGraphicsView()
        {
            String data = String.Empty;

            foreach (VideoControllerInformation.VideoControllerPropertyData videoControllerPropertyData in (VideoControllerInformation.VideoControllerPropertyData[])AppContext.Data.videoControllerInformation)
            {
                data += "-------------------\n";
                data += "Name: " + videoControllerPropertyData.gPropertyName + "\n";
                data += "Video Processor: " + videoControllerPropertyData.gPropertyVideoProcessor + "\n\n";
                data += "Display Drivers: " + videoControllerPropertyData.gPropertyInstalledDisplayDrivers + "\n";
                data += "Driver Version: " + videoControllerPropertyData.gPropertyDriverVersion + "\n";
                data += "Driver Date: " + videoControllerPropertyData.gPropertyDriverDate + "\n\n";
                data += "Availability: " + videoControllerPropertyData.gPropertyAvailability + "\n";
                data += "Adapter RAM: " + videoControllerPropertyData.gPropertyAdapterRAM + "\n\n";
                data += "Compatibility: " + videoControllerPropertyData.gPropertyAdapterCompatibility + "\n";
                data += "-------------------\n\n";
            }

            Label graphicsInformation = new Label();
            graphicsInformation.FontSize = AppContext.Data.fontSize;
            graphicsInformation.Content = data;
            gStackPanel.Children.Add(graphicsInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildPlugAndPlayView()
        {
            String data = String.Empty;

            foreach (PlugAndPlayEntityInformation.PlugAndPlayEntityPropertyData plugAndPlayEntityPropertyData in (PlugAndPlayEntityInformation.PlugAndPlayEntityPropertyData[])AppContext.Data.plugAndPlayEntityInformation)
            {
                data += "-------------------\n";
                data += "Name: " + plugAndPlayEntityPropertyData.gPropertyName + "\n";
                data += "Manufacturer: " + plugAndPlayEntityPropertyData.gPropertyManufacturer + "\n\n";
                data += "Service: " + plugAndPlayEntityPropertyData.gPropertyService + "\n";
                data += "PnP Class: " + plugAndPlayEntityPropertyData.gPropertyPNPClass + "\n";
                data += "PnP Device ID: " + plugAndPlayEntityPropertyData.gPropertyPNPDeviceID + "\n";
                data += "Availability: " + plugAndPlayEntityPropertyData.gPropertyAvailability + "\n";
                data += "Status: " + plugAndPlayEntityPropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label plugAndPlayInformation = new Label();
            plugAndPlayInformation.FontSize = AppContext.Data.fontSize;
            plugAndPlayInformation.Content = data;
            gStackPanel.Children.Add(plugAndPlayInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildDiskDrivesView()
        {
            String data = String.Empty;

            foreach (DiskDriveInformation.DiskDrivePropertyData diskDrivePropertyData in (DiskDriveInformation.DiskDrivePropertyData[])AppContext.Data.diskDriveInformation)
            {
                data += "-------------------\n";
                data += "Name: " + diskDrivePropertyData.gPropertyName + "\n";
                data += "Manufacturer: " + diskDrivePropertyData.gPropertyManufacturer + "\n\n";
                data += "Model: " + diskDrivePropertyData.gPropertyModel + "\n";
                data += "Size: " + diskDrivePropertyData.gPropertySize + "\n";
                data += "Compression Method: " + diskDrivePropertyData.gPropertyCompressionMethod + "\n\n";
                data += "Device ID: " + diskDrivePropertyData.gPropertyDeviceID + "\n";
                data += "PnP Device ID: " + diskDrivePropertyData.gPropertyPNPDeviceID + "\n\n";
                data += "Total Cylinders: " + diskDrivePropertyData.gPropertyTotalCylinders + "\n";
                data += "Total Heads: " + diskDrivePropertyData.gPropertyTotalHeads + "\n";
                data += "Total Sectors: " + diskDrivePropertyData.gPropertyTotalSectors + "\n";
                data += "Total Tracks: " + diskDrivePropertyData.gPropertyTotalTracks + "\n\n";
                data += "SCSI Bus: " + diskDrivePropertyData.gPropertySCSIBus + "\n";
                data += "SCSI Logical Unit: " + diskDrivePropertyData.gPropertySCSILogicalUnit + "\n";
                data += "SCSI Port: " + diskDrivePropertyData.gPropertySCSIPort + "\n";
                data += "SCSI Target ID: " + diskDrivePropertyData.gPropertySCSITargetId + "\n\n";
                data += "Availability: " + diskDrivePropertyData.gPropertyAvailability + "\n";
                data += "Status: " + diskDrivePropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label diskDrivesInformation = new Label();
            diskDrivesInformation.FontSize = AppContext.Data.fontSize;
            diskDrivesInformation.Content = data;
            gStackPanel.Children.Add(diskDrivesInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildFanView()
        {
            String data = String.Empty;

            foreach (FanInformation.FanPropertyData fanPropertyData in (FanInformation.FanPropertyData[])AppContext.Data.fanInformation)
            {
                data += "-------------------\n";
                data += "Name: " + fanPropertyData.gPropertyName + "\n";
                data += "Active Cooling: " + fanPropertyData.gPropertyActiveCooling + "\n\n";
                data += "Desired Speed: " + fanPropertyData.gPropertyDesiredSpeed + "\n";
                data += "Device ID: " + fanPropertyData.gPropertyDeviceID + "\n";
                data += "Availability: " + fanPropertyData.gPropertyAvailability + "\n";
                data += "Status: " + fanPropertyData.gPropertyStatus + "\n";
                data += "-------------------\n\n";
            }

            Label fanInformation = new Label();
            fanInformation.FontSize = AppContext.Data.fontSize;
            fanInformation.Content = data;
            gStackPanel.Children.Add(fanInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildBusView()
        {
            String data = String.Empty;

            foreach (BusInformation.BusPropertyData busPropertyData in (BusInformation.BusPropertyData[])AppContext.Data.busInformation)
            {
                data += "-------------------\n";
                data += "Name: " + busPropertyData.gPropertyName + "\n";
                data += "Bus Type: " + busPropertyData.gPropertyBusType + "\n\n";
                data += "Bus Num: " + busPropertyData.gPropertyBusNum + "\n";
                data += "Device ID: " + busPropertyData.gPropertyDeviceID + "\n";
                data += "-------------------\n\n";
            }

            Label busInformation = new Label();
            busInformation.FontSize = AppContext.Data.fontSize;
            busInformation.Content = data;
            gStackPanel.Children.Add(busInformation);

            AppContext.Data.dataToPrint = data;
        }

        private void BuildProcessView()
        {
            String data = String.Empty;

            foreach (ProcessInformation.ProcessPropertyData processPropertyData in (ProcessInformation.ProcessPropertyData[])AppContext.Data.processInformation)
            {
                data += "-------------------\n";
                data += "Name: " + processPropertyData.gPropertyName + "\n";
                data += "Command Line: " + processPropertyData.gPropertyCommandLine + "\n\n";
                data += "Process ID: " + processPropertyData.gPropertyProcessId + "\n";
                data += "Thread Count: " + processPropertyData.gPropertyThreadCount + "\n";
                data += "Priority: " + processPropertyData.gPropertyPriority + "\n";
                data += "-------------------\n\n";
            }

            Label processInformation = new Label();
            processInformation.FontSize = AppContext.Data.fontSize;
            processInformation.Content = data;
            gStackPanel.Children.Add(processInformation);

            AppContext.Data.dataToPrint = data;
        }

        public System.Windows.UIElement GetView()
        {
            return gStackPanel;
        }
    }
}
