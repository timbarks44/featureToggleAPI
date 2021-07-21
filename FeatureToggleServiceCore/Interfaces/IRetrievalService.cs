using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleServiceCore.Interfaces
{
    public interface IRetrievalService
    {
        Task<IEnumerable<FeatureToggle>> GetFeatureToggleById(int featureToggleId);
        Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductId(int productId);
        Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductIdAndStatus(int productId, int featureToggleStatus);
        Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductName(string productName);
        Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductNameAndStatus(string productName, int featureToggleStatus);
    }
}
