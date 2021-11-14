using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Interface that forces implementation of a GetPropertyValues method.
    /// </summary>
    public interface IPropertyProvider
    {
        String[] GetPropertyValues();
    }
}
