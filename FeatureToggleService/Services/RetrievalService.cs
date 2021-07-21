using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleService.Services
{
    public class RetrievalService : IRetrievalService
    {
        private readonly IRetriveFeatureToggleRepository _retriveFeatureToggleRepository;

        public RetrievalService(IRetriveFeatureToggleRepository retriveFeatureToggleRepository) 
        {
            _retriveFeatureToggleRepository = retriveFeatureToggleRepository;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureToggleById(int featureToggleId) 
        {
            var featureToggle = await _retriveFeatureToggleRepository.GetFeatureToggleById(featureToggleId);
            return featureToggle;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductId(int productId)
        {
            var featureToggle = await _retriveFeatureToggleRepository.GetFeatureTogglesByProductId(productId);
            return featureToggle;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductIdAndStatus(int productId, int featureToggleStatus)
        {
            var featureToggle = await _retriveFeatureToggleRepository.GetFeatureTogglesByProductIdAndStatus(productId, featureToggleStatus);
            return featureToggle;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductName(string productName)
        {
            var featureToggle = await _retriveFeatureToggleRepository.GetFeatureTogglesByProductName(productName);
            return featureToggle;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductNameAndStatus(string productName, int featureToggleStatus)
        {
            var featureToggle = await _retriveFeatureToggleRepository.GetFeatureTogglesByProductNameAndStatus(productName, featureToggleStatus);
            return featureToggle;
        }
    }
}
