using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleService.Services
{
    public class UpdateService : IUpdateService
    {
        private readonly IModifyFeatureToggleRepository _modifyFeatureToggleRepository;

        public UpdateService(IModifyFeatureToggleRepository modifyFeatureToggleRepository)
        {
            _modifyFeatureToggleRepository = modifyFeatureToggleRepository;
        }

        public async Task<IEnumerable<FeatureToggle>> UpdateFeatureToggle(FeatureToggle featureToggle)
        {
            var updatedFeatureToggle = await _modifyFeatureToggleRepository.UpdateFeatureToggleById(
                featureToggle.FeatureToggleId,
                featureToggle.ProductId,
                featureToggle.ProductName,
                featureToggle.FeatureToggleName,
                featureToggle.FeatureToggleStatus);

            return updatedFeatureToggle;
        }
    }
}
