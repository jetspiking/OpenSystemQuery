using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using OpenSystemQuery.Misc;
using System.Windows.Documents;

namespace OpenSystemQuery.Views
{
    public class ToolBar : IViewProvider
    {
        public StackPanel gButtonPanel = new StackPanel();
        public Button gButtonRefresh = new Button();
        public Button gButtonReturn = new Button();
        public Button gButtonForward = new Button();
        public Button gButtonZoomIn = new Button();
        public Button gButtonZoomOut = new Button();
        public Button gButtonOptions = new Button();
        public Button gButtonPrint = new Button();
        public Button gButtonAbout = new Button();
        public Button gButtonFullView = new Button();
        public Button gButtonClose = new Button();

        public ToolBar()
        {
            Image buttonRefreshImage = new Image();
            gButtonRefresh.Content = buttonRefreshImage;
            buttonRefreshImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.RefreshArrowGreen);
            gButtonRefresh.Click += new RoutedEventHandler(gButtonRefresh_Click);

            Image buttonReturnImage = new Image();
            gButtonReturn.Content = buttonReturnImage;
            buttonReturnImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.ArrowReturnLeftBlue);
            gButtonReturn.Click += new RoutedEventHandler(gButtonReturn_Click);

            Image buttonForwardImage = new Image();
            gButtonForward.Content = buttonForwardImage;
            buttonForwardImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.ArrowReturnRightBlue);
            gButtonForward.Click += new RoutedEventHandler(gButtonForward_Click);

            Image buttonZoomInImage = new Image();
            gButtonZoomIn.Content = buttonZoomInImage;
            buttonZoomInImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.ZoomIn);
            gButtonZoomIn.Click += new RoutedEventHandler(gButtonZoomIn_Click);

            Image buttonZoomOutImage = new Image();
            gButtonZoomOut.Content = buttonZoomOutImage;
            buttonZoomOutImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.ZoomOut);
            gButtonZoomOut.Click += new RoutedEventHandler(gButtonZoomOut_Click);

            Image buttonOptionsImage = new Image();
            gButtonOptions.Content = buttonOptionsImage;
            buttonOptionsImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.Options);

            Image buttonPrintImage = new Image();
            gButtonPrint.Content = buttonPrintImage;
            buttonPrintImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.PrintView);
            gButtonPrint.Click += new RoutedEventHandler(gButtonPrint_Click);

            Image buttonAboutImage = new Image();
            gButtonAbout.Content = buttonAboutImage;
            buttonAboutImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.AnnotationsHelp);
            gButtonAbout.Click += new RoutedEventHandler(gButtonAbout_Click);

            Image buttonFullViewImage = new Image();
            gButtonFullView.Content = buttonFullViewImage;
            buttonFullViewImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.FullView);
            gButtonFullView.Click += new RoutedEventHandler(gButtonFullView_Click);

            Image buttonCloseImage = new Image();
            gButtonClose.Content = buttonCloseImage;
            buttonCloseImage.Source = Utils.Image.GetIconImage(Utils.Image.IconImages.Close);
            gButtonClose.Click += new RoutedEventHandler(gButtonClose_Click);

            gButtonPanel.Background = new SolidColorBrush(Colors.WhiteSmoke);
            gButtonPanel.HorizontalAlignment = HorizontalAlignment.Left;
            gButtonPanel.Orientation = Orientation.Horizontal;
            gButtonPanel.Children.Add(gButtonRefresh);
            gButtonPanel.Children.Add(gButtonReturn);
            gButtonPanel.Children.Add(gButtonForward);
            gButtonPanel.Children.Add(gButtonZoomIn);
            gButtonPanel.Children.Add(gButtonZoomOut);
            gButtonPanel.Children.Add(gButtonOptions);
            gButtonPanel.Children.Add(gButtonPrint);
            gButtonPanel.Children.Add(gButtonAbout);
            gButtonPanel.Children.Add(gButtonFullView);
            gButtonPanel.Children.Add(gButtonClose);
        }

        void gButtonForward_Click(object sender, RoutedEventArgs e)
        {
            if (AppContext.Data.systemActorsHistory.Count < 2) return;
            AppContext.Data.mainWindow.Interacted(AppContext.Data.systemActorsHistory.Pop());
            AppContext.Data.mainWindow.gSystemView.ToggleButton(AppContext.Data.systemActorsHistory.Peek());
        }

        void gButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            if (AppContext.Data.systemActorsHistory.Count < 2) return;
            SystemActors current = AppContext.Data.systemActorsHistory.Pop();
            AppContext.Data.mainWindow.Interacted(AppContext.Data.systemActorsHistory.Pop());
            AppContext.Data.mainWindow.gSystemView.ToggleButton(AppContext.Data.systemActorsHistory.Peek());
            AppContext.Data.systemActorsHistory.Push(current);
        }

        void gButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new PrintDialog();
            printDialog.PageRangeSelection = PageRangeSelection.AllPages;
            printDialog.UserPageRangeEnabled = false;
            if (printDialog.ShowDialog() == true)
            {
                var document = new FlowDocument();
                document.ColumnWidth = printDialog.PrintableAreaWidth;
                document.Blocks.Add(new Paragraph(new Run(AppContext.Data.dataToPrint)));
                printDialog.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Open System Query");
            }
        }

        void gButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            AppContext.Data.mainWindow.LoadData();
        }

        void gButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jetspiking/OpenSystemQuery");
        }

        void gButtonClose_Click(object sender, RoutedEventArgs e)
        {
            AppContext.Data.mainWindow.Close();
        }

        void gButtonZoomOut_Click(object sender, RoutedEventArgs e)
        {
            if (AppContext.Data.fontSize-1>0)
                AppContext.Data.fontSize--;
            AppContext.Data.mainWindow.gContainerView.Update();
        }

        void gButtonZoomIn_Click(object sender, RoutedEventArgs e)
        {
            AppContext.Data.fontSize++;
            AppContext.Data.mainWindow.gContainerView.Update();
        }

        void gButtonFullView_Click(object sender, RoutedEventArgs e)
        {
            if (AppContext.Data.mainWindow.WindowState == WindowState.Maximized)
                AppContext.Data.mainWindow.WindowState = WindowState.Normal;
            else AppContext.Data.mainWindow.WindowState = WindowState.Maximized;
            AppContext.Data.mainWindow.Update();
        }

        public void Update(double width, double height)
        {
            gButtonPanel.Width = width;

            foreach (Button button in gButtonPanel.Children)
            {
                button.Width = 38;
                button.Height = 38;
                button.Background = null;
                button.BorderBrush = null;
            }
        }

        public System.Windows.UIElement GetView()
        {
            return gButtonPanel;
        }
    }
}
