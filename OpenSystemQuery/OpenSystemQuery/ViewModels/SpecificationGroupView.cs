using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenSystemQuery.Views;
using System.Windows.Controls;
using OpenSystemQuery.InformationManagement;
using System.Windows;

namespace OpenSystemQuery.ViewModels
{
    public class SpecificationGroupView : IViewProvider
    {
        public StackPanel gStackPanel = new StackPanel();
        public RadioButton gToggleButton = new RadioButton();
        public Label gLabel = new Label();
        public String gTitle;

        public SpecificationGroupView(String title)
        {
            gTitle = title;
            gLabel.Content = title;

            gStackPanel.Orientation = Orientation.Horizontal;
            gStackPanel.Children.Add(gToggleButton);
            gStackPanel.Children.Add(gLabel);

            gToggleButton.VerticalAlignment = VerticalAlignment.Center;
            gLabel.VerticalAlignment = VerticalAlignment.Center;

            //gToggleButton.Margin = new System.Windows.Thickness(5, 5, 5, 5);
            //gLabel.Margin = new System.Windows.Thickness(5, 5, 5, 5);
        }

        public System.Windows.UIElement GetView()
        {
            return gStackPanel;
        }
    }
}
