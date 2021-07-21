using FeatureToggleServiceCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeatureToggleServiceCore.Interfaces
{
    public interface IUpdateService
    {
        Task<IEnumerable<FeatureToggle>> UpdateFeatureToggle(FeatureToggle featureToggle);
    }
}
