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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenSystemQuery.InformationManagement;
using System.Diagnostics;
using System.Reflection;
using OpenSystemQuery.Views;
using OpenSystemQuery.Misc;
using OpenSystemQuery.ViewModels;

namespace OpenSystemQuery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifier, ISystemInteractor
    {
        public OpenSystemQuery.Views.ToolBar gToolBar;
        public LoadingWindow gLoadingWindow;
        public SystemView gSystemView;
        public ContainerView gContainerView;

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Open System Query";
            AppContext.Data.mainWindow = this;

            this.ResizeMode = ResizeMode.NoResize;
            
            gToolBar = new OpenSystemQuery.Views.ToolBar();
            XAML_TopBar.Children.Add((StackPanel)gToolBar.GetView());

            LoadData();

            Update();
        }

        public void LoadData()
        {
            XAML_SystemBox.Content = null;
            XAML_ContainerBox.Content = null;
            gLoadingWindow = new LoadingWindow(this);
            gLoadingWindow.Topmost = true;
            gLoadingWindow.Show();
        }

        public void Update()
        {
            Byte scrollbarWidthMargin = 5;
            XAML_ContainerBox.Width = 2*this.Width / 3-scrollbarWidthMargin;
            XAML_SystemBox.Width = this.Width / 3;                             

            gToolBar.Update(this.Width - scrollbarWidthMargin, this.Height);

            XAML_OSQMenu.Width = this.Width;
        }

        public void Notify()
        {
            gLoadingWindow.Close();
            gSystemView = new SystemView(this);
            XAML_SystemBox.Content = gSystemView.GetView();
        }

        public void Interacted(SystemActors systemActor)
        {
            gContainerView = new ContainerView(systemActor);
            XAML_ContainerBox.Content = gContainerView.GetView();
        }

        private void RefreshItem_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SystemItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.System);
            Interacted(SystemActors.System);
        }

        private void ProcessorItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Processor);
            Interacted(SystemActors.Processor);
        }

        private void BaseBoardItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Motherboard);
            Interacted(SystemActors.Motherboard);
        }

        private void MemoryItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Memory);
            Interacted(SystemActors.Memory);
        }

        private void BusItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Bus);
            Interacted(SystemActors.Bus);
        }

        private void GraphicsItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.VideoAdapter);
            Interacted(SystemActors.VideoAdapter);
        }

        private void PNPItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.PnPEntity);
            Interacted(SystemActors.PnPEntity);
        }

        private void DiskDrivesItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Drives);
            Interacted(SystemActors.Drives);
        }

        private void FanItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Fans);
            Interacted(SystemActors.Fans);
        }

        private void ProcessesItem_Click(object sender, RoutedEventArgs e)
        {
            gSystemView.ToggleButton(SystemActors.Process);
            Interacted(SystemActors.Process);
        }
    }
}
