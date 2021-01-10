using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioExample.Models
{
    public partial class Step
    {
        public Step()
        {
            MeasurementForSteps = new HashSet<MeasurementForStep>();
        }

        public int Id { get; set; }
        public int? NumberInList { get; set; }
        public int? ActionId { get; set; }
        public string Notes { get; set; }
        public int? RecipeId { get; set; }
        public List<Measurement> Measurements { get; set; }

        //public virtual Action Action { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual ICollection<MeasurementForStep> MeasurementForSteps { get; set; }
    }
}
