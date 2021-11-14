using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Stores Process Data.
    /// </summary>
    public class ProcessInformation : Updatable, IUpdatable
    {
        public class ProcessPropertyList : PropertyProvider, IPropertyProvider
        {
            public readonly String gPropertyCreationClassName = "CreationClassName";
            public readonly String gPropertyCaption = "Caption";
            public readonly String gPropertyCommandLine = "CommandLine";
            public readonly String gPropertyCreationDate = "CreationDate";
            public readonly String gPropertyCSCreationClassName = "CSCreationClassName";
            public readonly String gPropertyCSName = "CSName";
            public readonly String gPropertyDescription = "Description";
            public readonly String gPropertyExecutablePath = "ExecutablePath";
            public readonly String gPropertyExecutionState = "ExecutionState";
            public readonly String gPropertyHandle = "Handle";
            public readonly String gPropertyHandleCount = "HandleCount";
            public readonly String gPropertyInstallDate = "InstallDate";
            public readonly String gPropertyKernelModeTime = "KernelModeTime";
            public readonly String gPropertyMaximumWorkingSetSize = "MaximumWorkingSetSize";
            public readonly String gPropertyMinimumWorkingSetSize = "MinimumWorkingSetSize";
            public readonly String gPropertyName = "Name";
            public readonly String gPropertyOtherOperationCount = "OtherOperationCount";
            public readonly String gPropertyOtherTransferCount = "OtherTransferCount";
            public readonly String gPropertyPageFaults = "PageFaults";
            public readonly String gPropertyPageFileUsage = "PageFileUsage";
            public readonly String gPropertyParentProcessID = "ParentProcessId";
            public readonly String gPropertyPeakPageFileUsage = "PeakPageFileUsage";
            public readonly String gPropertyPeakVirtualSize = "PeakVirtualSize";
            public readonly String gPropertyPeakWorkingSetSize = "PeakWorkingSetSize";
            public readonly String gPropertyPriority = "Priority";
            public readonly String gPropertyPrivatePageCount = "PrivatePageCount";
            public readonly String gPropertyProcessId = "ProcessId";
            public readonly String gPropertyQuotaNonPagedPoolUsage = "QuotaNonPagedPoolUsage";
            public readonly String gPropertyQuotaPagedPoolUsage = "QuotaPagedPoolUsage";
            public readonly String gPropertyQuotaPeakNonPagedPoolUsage = "QuotaPeakNonPagedPoolUsage";
            public readonly String gPropertyQuotaPeakPagedPoolUsage = "QuotaPeakPagedPoolUsage";
            public readonly String gPropertyReadOperationCount = "ReadOperationCount";
            public readonly String gPropertyReadTransferCount = "ReadTransferCount";
            public readonly String gPropertySessionId = "SessionId";
            public readonly String gPropertyStatus = "Status";
            public readonly String gPropertyTerminationDate = "TerminationDate";
            public readonly String gPropertyThreadCount = "ThreadCount";
            public readonly String gPropertyUserModeTime = "UserModeTime";
            public readonly String gPropertyVirtualSize = "VirtualSize";
            public readonly String gPropertyWindowsVersion = "WindowsVersion";
            public readonly String gPropertyWorkingSetSize = "WorkingSetSize";
            public readonly String gPropertyWriteOperationCount = "WriteOperationCount";
            public readonly String gPropertyWriteTransferCount = "WriteTransferCount";

            public string[] GetPropertyValues()
            {
                ProcessPropertyList propertyList = new ProcessPropertyList();
                return propertyList.GetPropertyValues(this);
            }
        }

        public class ProcessPropertyData : AbstractPropertyData
        {
            public String gPropertyCreationClassName;
            public String gPropertyCaption;
            public String gPropertyCommandLine;
            public String gPropertyCreationDate;
            public String gPropertyCSCreationClassName;
            public String gPropertyCSName;
            public String gPropertyDescription;
            public String gPropertyExecutablePath;
            public String gPropertyExecutionState;
            public String gPropertyHandle;
            public String gPropertyHandleCount;
            public String gPropertyInstallDate;
            public String gPropertyKernelModeTime;
            public String gPropertyMaximumWorkingSetSize;
            public String gPropertyMinimumWorkingSetSize;
            public String gPropertyName;
            public String gPropertyOtherOperationCount;
            public String gPropertyOtherTransferCount;
            public String gPropertyPageFaults;
            public String gPropertyPageFileUsage;
            public String gPropertyParentProcessID;
            public String gPropertyPeakPageFileUsage;
            public String gPropertyPeakVirtualSize;
            public String gPropertyPeakWorkingSetSize;
            public String gPropertyPriority;
            public String gPropertypublicPageCount;
            public String gPropertyProcessId;
            public String gPropertyQuotaNonPagedPoolUsage;
            public String gPropertyQuotaPagedPoolUsage;
            public String gPropertyQuotaPeakNonPagedPoolUsage;
            public String gPropertyQuotaPeakPagedPoolUsage;
            public String gPropertyReadOperationCount;
            public String gPropertyReadTransferCount;
            public String gPropertySessionId;
            public String gPropertyStatus;
            public String gPropertyTerminationDate;
            public String gPropertyThreadCount;
            public String gPropertyUserModeTime;
            public String gPropertyVirtualSize;
            public String gPropertyWindowsVersion;
            public String gPropertyWorkingSetSize;
            public String gPropertyWriteOperationCount;
            public String gPropertyWriteTransferCount;
        }

        public ProcessInformation() : base("SELECT * FROM Win32_Process")
        {

        }

        public AbstractPropertyData[] Update()
        {
            return this.Update(new ProcessPropertyList(), new ProcessPropertyData());
        }
    }
}
