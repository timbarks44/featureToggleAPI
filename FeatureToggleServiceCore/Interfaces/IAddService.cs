using FeatureToggleServiceCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleServiceCore.Interfaces
{
    public interface IAddService
    {
        Task<IEnumerable<FeatureToggle>> CreateFeatureToggle(FeatureToggle featureToggle);
    }
}
