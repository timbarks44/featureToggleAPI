using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleService.Services
{
    public class AddService : IAddService
    {
        private readonly IModifyFeatureToggleRepository _modifyFeatureToggleRepository;

        public AddService(IModifyFeatureToggleRepository modifyFeatureToggleRepository) 
        {
            _modifyFeatureToggleRepository = modifyFeatureToggleRepository;
        }

        public async Task<IEnumerable<FeatureToggle>> CreateFeatureToggle(FeatureToggle featureToggle) 
        {
            var newFeatureToggle = await _modifyFeatureToggleRepository.AddNewFeatureToggle(
                featureToggle.ProductId,
                featureToggle.ProductName,
                featureToggle.FeatureToggleName,
                featureToggle.FeatureToggleStatus);

            return newFeatureToggle;
        }
    }
}
