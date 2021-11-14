using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using OpenSystemQuery.InformationManagement;
using OpenSystemQuery.ViewModels;
using OpenSystemQuery.Misc;

namespace OpenSystemQuery.Views
{
    public class SystemView : IViewProvider
    {
        public StackPanel gStackPanel = new StackPanel();
        public SpecificationGroupView gComputerSystemGroup;
        public SpecificationGroupView gCentralProcessors;
        public SpecificationGroupView gBaseBoard;
        public SpecificationGroupView gMemory;
        public SpecificationGroupView gGraphicsProcessors;
        public SpecificationGroupView gPnPEntities;
        public SpecificationGroupView gDrives;
        public SpecificationGroupView gFans;
        public SpecificationGroupView gBus;
        public SpecificationGroupView gProcess;
        public ISystemInteractor gSystemInteractor;

        public SystemView(ISystemInteractor iSystemInteractor)
        {
            gStackPanel.Margin = new System.Windows.Thickness(5, 5, 5, 5);
            gSystemInteractor = iSystemInteractor;

            String computerSystemName = ((OperatingSystemInformation.OperatingSystemPropertyData)(AppContext.Data.operatingSystemInformation[0])).gPropertyCSName;
            gComputerSystemGroup = new SpecificationGroupView(computerSystemName);
            gCentralProcessors = new SpecificationGroupView("Central Processors");
            gBaseBoard = new SpecificationGroupView("Motherboard");
            gMemory = new SpecificationGroupView("Memory");
            gGraphicsProcessors = new SpecificationGroupView("Graphics Processors");
            gPnPEntities = new SpecificationGroupView("PnP Entities");
            gDrives = new SpecificationGroupView("Disk Drives");
            gFans = new SpecificationGroupView("Fans");
            gBus = new SpecificationGroupView("Bus");
            gProcess = new SpecificationGroupView("Process");

            gCentralProcessors.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gBaseBoard.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gMemory.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gGraphicsProcessors.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gPnPEntities.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gDrives.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gFans.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gBus.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);
            gProcess.gStackPanel.Margin = new System.Windows.Thickness(15, 0, 0, 0);

            gStackPanel.Children.Add(gComputerSystemGroup.GetView());
            gStackPanel.Children.Add(gCentralProcessors.GetView());
            gStackPanel.Children.Add(gBaseBoard.GetView());
            gStackPanel.Children.Add(gMemory.GetView());
            gStackPanel.Children.Add(gGraphicsProcessors.GetView());
            gStackPanel.Children.Add(gPnPEntities.GetView());
            gStackPanel.Children.Add(gDrives.GetView());
            gStackPanel.Children.Add(gFans.GetView());
            gStackPanel.Children.Add(gBus.GetView());
            gStackPanel.Children.Add(gProcess.GetView());

            gComputerSystemGroup.gToggleButton.Click += new System.Windows.RoutedEventHandler(gComputerSystemGroup_Click);
            gCentralProcessors.gToggleButton.Click += new System.Windows.RoutedEventHandler(gCentralProcessors_Click);
            gBaseBoard.gToggleButton.Click += new System.Windows.RoutedEventHandler(gBaseBoard_Click);
            gMemory.gToggleButton.Click += new System.Windows.RoutedEventHandler(gMemory_Click);
            gGraphicsProcessors.gToggleButton.Click += new System.Windows.RoutedEventHandler(gGraphicsProcessor_Click);
            gPnPEntities.gToggleButton.Click += new System.Windows.RoutedEventHandler(gPnPEntities_Click);
            gDrives.gToggleButton.Click += new System.Windows.RoutedEventHandler(gDrives_Click);
            gFans.gToggleButton.Click += new System.Windows.RoutedEventHandler(gFans_Click);
            gBus.gToggleButton.Click += new System.Windows.RoutedEventHandler(gBus_Click);
            gProcess.gToggleButton.Click += new System.Windows.RoutedEventHandler(gToggleButton_Click);
        }

        public void ToggleButton(SystemActors systemActor)
        {
            ResetToggleSwitches();

            switch (systemActor)
            {
                case SystemActors.System:
                    gComputerSystemGroup.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.Processor:
                    gCentralProcessors.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.Motherboard:
                    gBaseBoard.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.Memory:
                    gMemory.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.VideoAdapter:
                    gGraphicsProcessors.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.PnPEntity:
                    gPnPEntities.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.Drives:
                    gDrives.gToggleButton.IsChecked = true;
                    break;
                case SystemActors.Fans:
                    gFans.gToggleButton.IsChecked=true;
                    break;
                case SystemActors.Bus:
                    gBus.gToggleButton.IsChecked=true;
                    break;
                case SystemActors.Process:
                    gProcess.gToggleButton.IsChecked=true;
                    break;
            }
        }

        private void gToggleButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gProcess.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Process);
        }

        private void gBus_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gBus.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Bus);
        }

        private void gFans_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gFans.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Fans);
        }

        private void gDrives_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gDrives.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Drives);
        }

        private void gPnPEntities_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gPnPEntities.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.PnPEntity);
        }

        private void gGraphicsProcessor_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gGraphicsProcessors.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.VideoAdapter);
        }

        private void gMemory_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gMemory.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Memory);
        }

        private void gBaseBoard_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gBaseBoard.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Motherboard);
        }

        private void gCentralProcessors_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gCentralProcessors.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.Processor);
        }

        private void gComputerSystemGroup_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ResetToggleSwitches();
            gComputerSystemGroup.gToggleButton.IsChecked = true;
            gSystemInteractor.Interacted(SystemActors.System);
        }

        private void ResetToggleSwitches()
        {
            gComputerSystemGroup.gToggleButton.IsChecked = false;
            gCentralProcessors.gToggleButton.IsChecked = false;
            gBaseBoard.gToggleButton.IsChecked = false;
            gMemory.gToggleButton.IsChecked = false;
            gGraphicsProcessors.gToggleButton.IsChecked = false;
            gPnPEntities.gToggleButton.IsChecked = false;
            gDrives.gToggleButton.IsChecked = false;
            gFans.gToggleButton.IsChecked = false;
            gBus.gToggleButton.IsChecked = false;
            gProcess.gToggleButton.IsChecked = false;
        }

        public System.Windows.UIElement GetView()
        {
            return gStackPanel;
        }
    }
}
