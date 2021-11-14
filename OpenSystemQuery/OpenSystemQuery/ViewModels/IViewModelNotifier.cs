using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.ViewModels
{
    public interface IViewModelNotifier
    {
        void ClickedOn(IViewModelNotifier iViewModelNotifier);
    }
}
