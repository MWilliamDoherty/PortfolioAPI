using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioExample.Models
{
    public partial class MeasurementType
    {
        public MeasurementType()
        {
            Measurements = new HashSet<Measurement>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public bool? UnitOfMeasure { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}
