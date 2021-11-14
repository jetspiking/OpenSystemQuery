using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OpenSystemQuery.InformationManagement;
using System.Threading;
using OpenSystemQuery.Misc;

namespace OpenSystemQuery
{
    /// <summary>
    /// Interaction logic for LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        public StackPanel gStackPanel = new StackPanel();
        public ProgressBar gProgressBar = new ProgressBar();
        public Label gLoadingInfoLabel = new Label();

        private double mProgress = 0;
        private const int mLoadAmount = 16;
        private INotifier mNotifier; 

        public LoadingWindow(INotifier notifier)
        {
            InitializeComponent();
            mNotifier = notifier;

            gStackPanel.Orientation = Orientation.Vertical;

            Image osq = new Image();
            osq.Source = Utils.Image.GetImage(Utils.Image.AppImages.OpenSystemQueryDark);
            osq.Height = 100;
            osq.Margin = new Thickness(0, 0, 0, 10);

            gLoadingInfoLabel.Margin = new Thickness(5, 5, 5, 15);

            gStackPanel.Children.Add(osq);
            gStackPanel.Children.Add(gProgressBar);
            gStackPanel.Children.Add(gLoadingInfoLabel);

            this.Content = gStackPanel;
            this.Topmost = true;
            this.Title = "Querying System";
            this.Width = 400;
            this.Height = 230;
            this.ResizeMode = ResizeMode.NoResize;

            gProgressBar.Width = 350;
            gProgressBar.Height = 50;
            gProgressBar.Minimum = 0;
            gProgressBar.Maximum = 100;

            LoadData();
        }

        public void LoadData()
        {
            mProgress = 0;
            new Thread(ThreadedLoadData).Start();
        }

        private void ThreadedLoadData()
        {
            SetProgress();
            SetText("BaseBoard");
            AppContext.Data.baseBoardInformation = (new BaseBoardInformation()).Update();

            SetProgress();
            SetText("Battery");
            AppContext.Data.batteryInformation = (new BatteryInformation()).Update();

            SetProgress();
            SetText("Bios");
            AppContext.Data.biosInformation = (new BiosInformation()).Update();

            SetProgress();
            SetText("BootConfiguration");
            AppContext.Data.bootConfiguration = (new BootConfigurationInformation()).Update();

            SetProgress();
            SetText("Bus");
            AppContext.Data.busInformation = (new BusInformation()).Update();

            SetProgress();
            SetText("DiskDrive");
            AppContext.Data.diskDriveInformation = (new DiskDriveInformation()).Update();

            SetProgress();
            SetText("Fan");
            AppContext.Data.fanInformation = (new FanInformation()).Update();

            SetProgress();
            SetText("LogicalDisk");
            AppContext.Data.logicalDiskInformation = (new LogicalDiskInformation()).Update();

            SetProgress();
            SetText("NetworkAdapter");
            AppContext.Data.networkAdapterInformation = (new NetworkAdapterInformation()).Update();

            SetProgress();
            SetText("OperatingSystem");
            AppContext.Data.operatingSystemInformation = (new OperatingSystemInformation()).Update();

            SetProgress();
            SetText("PhysicalMemory");
            AppContext.Data.physicalMemoryInformation = (new PhysicalMemoryInformation()).Update();

            SetProgress();
            SetText("PnPEntity");
            AppContext.Data.plugAndPlayEntityInformation = (new PlugAndPlayEntityInformation()).Update();

            SetProgress();
            SetText("Process");
            AppContext.Data.processInformation = (new ProcessInformation()).Update();

            SetProgress();
            SetText("Processor");
            AppContext.Data.processorInformation = (new ProcessorInformation()).Update();

            SetProgress();
            SetText("Temperature");
            AppContext.Data.temperatureProbeInformation = (new TemperatureProbeInformation()).Update();

            SetProgress();
            SetText("Video Controllers");
            AppContext.Data.videoControllerInformation = (new VideoControllerInformation()).Update();

            Application.Current.Dispatcher.Invoke(
                new Action(() =>
                {
                    mNotifier.Notify();
                }));
        }

        private void SetText(String text)
        {
            Application.Current.Dispatcher.Invoke(
                new Action(() =>
                {
                    gLoadingInfoLabel.Content = "Querying "+text;
                }));
        }

        private void SetProgress()
        {
            mProgress += 100 / mLoadAmount;
            Application.Current.Dispatcher.Invoke(
                new Action(() =>
                {
                    gProgressBar.Value = mProgress;

                }));
        }
    }
}
