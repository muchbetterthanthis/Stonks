using Stonks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stonks.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<IDeal> Deals { get; set; }
    }
}
