using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggleServiceInfrastructure.Repositories
{
    public class RetriveFeatureToggleRepository : IRetriveFeatureToggleRepository
    {
        public async Task<IEnumerable<FeatureToggle>> GetFeatureToggleById(int featureToggleId)
        {
            var featureToggleList = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.1",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 2,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.2",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 3,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.3",
                    FeatureToggleStatus = 1
                }
            };

            return featureToggleList
                .Where(feature => feature.FeatureToggleId == featureToggleId);
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductId(int productId)
        {
            var featureToggleList = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = 2,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.1",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 2,
                    ProductId = 2,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.2",
                    FeatureToggleStatus = 0
                },
                new FeatureToggle
                {
                    FeatureToggleId = 3,
                    ProductId = 4,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.3",
                    FeatureToggleStatus = 1
                }
            };

            return featureToggleList
                .Where(feature => feature.ProductId == productId);
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductIdAndStatus(int productId, int featureToggleStatus)
        {
            var featureToggles = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = 2,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.1",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 2,
                    ProductId = 2,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.2",
                    FeatureToggleStatus = 0
                },
                new FeatureToggle
                {
                    FeatureToggleId = 3,
                    ProductId = 4,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.3",
                    FeatureToggleStatus = 1
                }
            };

            return featureToggles;
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductName(string productName)
        {
            var featureToggleList = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.1",
                    FeatureToggleStatus = 0
                },
                new FeatureToggle
                {
                    FeatureToggleId = 2,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.2",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 3,
                    ProductId = 6,
                    ProductName = "van",
                    FeatureToggleName = "testFeatureTogggle.3",
                    FeatureToggleStatus = 0
                }
            };

            return featureToggleList
                .Where(feature => feature.ProductName == productName);
        }

        public async Task<IEnumerable<FeatureToggle>> GetFeatureTogglesByProductNameAndStatus(string productName, int featureToggleStatus)
        {
            var featureToggles = new List<FeatureToggle>
            {
                new FeatureToggle
                {
                    FeatureToggleId = 1,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.1",
                    FeatureToggleStatus = 0
                },
                new FeatureToggle
                {
                    FeatureToggleId = 2,
                    ProductId = 6,
                    ProductName = "van",
                    FeatureToggleName = "testFeatureTogggle.2",
                    FeatureToggleStatus = 1
                },
                new FeatureToggle
                {
                    FeatureToggleId = 3,
                    ProductId = 6,
                    ProductName = "car",
                    FeatureToggleName = "testFeatureTogggle.3",
                    FeatureToggleStatus = 0
                }
            };

            return featureToggles;
        }
    }
}
