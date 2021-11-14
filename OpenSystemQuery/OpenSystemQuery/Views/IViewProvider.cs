using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace OpenSystemQuery.Views
{
    public interface IViewProvider
    {
        UIElement GetView();
    }
}
