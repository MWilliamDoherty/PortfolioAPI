using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioExample.Models
{
    public partial class Action
    {
        public Action()
        {
            Steps = new HashSet<Step>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Step> Steps { get; set; }
    }
}
