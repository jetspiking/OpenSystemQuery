using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSystemQuery.InformationManagement
{
    /// <summary>
    /// Interface that provides an Update method which returns data.
    /// </summary>

    public interface IUpdatable
    {
        AbstractPropertyData[] Update();
    }
}
