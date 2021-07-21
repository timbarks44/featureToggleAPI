using System;
using System.Collections.Generic;
using System.Text;

namespace FeatureToggleServiceCore.Models
{
    public class FeatureToggle
    {
        public int FeatureToggleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string FeatureToggleName { get; set; }
        public int FeatureToggleStatus { get; set; }
    }
}
