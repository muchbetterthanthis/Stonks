using Stonks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stonks.Data.Entities
{
    public class Bet : IDeal, IHaveProfit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double BoughtPrice { get; set; }
        public uint Amount { get; set; }

        public double GetProfit()
        {
            return BoughtPrice - CurrentPrice;
        }
    }
}
