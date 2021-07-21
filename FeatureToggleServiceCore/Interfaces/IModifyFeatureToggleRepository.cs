using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleServiceCore.Interfaces
{
    public interface IModifyFeatureToggleRepository
    {
        Task<IEnumerable<FeatureToggle>> AddNewFeatureToggle(int productId,
            string productName,
            string featureToggleName,
            int featureToggleStatus);

        Task<IEnumerable<FeatureToggle>> UpdateFeatureToggleById(
            int featureToggleId,
            int productId,
            string productName,
            string featureToggleName,
            int featureToggleStatus);
    }
}
