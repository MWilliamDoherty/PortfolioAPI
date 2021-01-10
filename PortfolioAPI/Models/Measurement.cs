using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PortfolioExample.Models
{
    public partial class Measurement
    {
        public Measurement()
        {
            MeasurementForSteps = new HashSet<MeasurementForStep>();
        }

        public int Id { get; set; }
        public int? IngredientId { get; set; }
        public int? MeasurementTypeId { get; set; }
        public decimal? Quantity { get; set; }
        public Ingredient Ingredient { get; set; }

        public virtual MeasurementType MeasurementType { get; set; }
        public virtual ICollection<MeasurementForStep> MeasurementForSteps { get; set; }
    }
}
