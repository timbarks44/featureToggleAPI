using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleServiceInfrastructure.Repositories
{
    public class ModifyFeatureToggleRepository : IModifyFeatureToggleRepository
    {
        public async Task<IEnumerable<FeatureToggle>> AddNewFeatureToggle(
            int productId, 
            string productName, 
            string featureToggleName,
            int featureToggleStatus) 
        {
            var newFeatureToggle = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = productId,
                    ProductName = productName,
                    FeatureToggleName = featureToggleName,
                    FeatureToggleStatus = featureToggleStatus
                }
            };

            return newFeatureToggle;
        }

        public async Task<IEnumerable<FeatureToggle>> UpdateFeatureToggleById(
            int featureToggleId,
            int productId,
            string productName,
            string featureToggleName,
            int featureToggleStatus)
        {
            var newFeatureToggle = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = featureToggleId,
                    ProductId = productId,
                    ProductName = productName,
                    FeatureToggleName = featureToggleName,
                    FeatureToggleStatus = featureToggleStatus
                }
            };

            return newFeatureToggle;
        }
    }
}
