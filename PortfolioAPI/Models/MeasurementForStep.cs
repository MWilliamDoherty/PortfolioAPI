using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioExample.Models
{
    public partial class MeasurementForStep
    {
        public int Id { get; set; }
        public int? StepId { get; set; }
        public int? MeasurementId { get; set; }

        public virtual Measurement Measurement { get; set; }
        public virtual Step Step { get; set; }
    }
}
