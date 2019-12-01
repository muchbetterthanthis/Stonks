using System;
using System.Collections.Generic;
using System.Text;

namespace Stonks.Domain.Interfaces
{
    public interface IDeal
    {
        string Name { get; set; }
        double CurrentPrice { get; set; }
        double BoughtPrice { get; set; }
    }
}
