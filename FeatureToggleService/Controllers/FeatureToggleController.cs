using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeatureToggleServiceCore.Interfaces;
using FeatureToggleServiceCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeatureToggleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureToggleController : ControllerBase
    {
        private readonly IAddService _addService;
        private readonly IRetrievalService _retrievalService;
        private readonly IUpdateService _updateService;

        public FeatureToggleController(
            IAddService addService, 
            IRetrievalService retrievalService, 
            IUpdateService updateService) 
        {
            _addService = addService;
            _retrievalService = retrievalService;
            _updateService = updateService;
        }

        [HttpPost("AddFeatureToggle")]
        public async Task<ActionResult<FeatureToggle>> Add(FeatureToggle featureToggle) 
        {
            var newfeatureToggle = await _addService.CreateFeatureToggle(featureToggle);
            return StatusCode(201, newfeatureToggle);
        }

        [HttpPost("UpdateFeatureToggle")]
        public async Task<ActionResult<FeatureToggle>> Update(FeatureToggle featureToggle)
        {
            var updatedFeatureToggle = await _updateService.UpdateFeatureToggle(featureToggle);
            return StatusCode(201, updatedFeatureToggle);
        }

        [HttpGet("GetByFeatureId/{feature}")]
        public async Task<ActionResult<FeatureToggle>> Get(int featureToggleId) 
        {
            var featureToggle = await _retrievalService.GetFeatureToggleById(featureToggleId);
            return StatusCode(201, featureToggle);
        }

        [HttpGet("GetByProductId/{product}")]
        public async Task<ActionResult<FeatureToggle>> GetProduct(int productId)
        {
            var featureToggles = await _retrievalService.GetFeatureTogglesByProductId(productId);
            return StatusCode(201, featureToggles);
        }

        [HttpGet("GetByProductId/{product}/{status}")]
        public async Task<ActionResult<FeatureToggle>> GetProduct(int productId, int featureToggleStatus)
        {
            var featureToggles = await _retrievalService.GetFeatureTogglesByProductIdAndStatus(productId, featureToggleStatus);
            return StatusCode(201, featureToggles);
        }

        [HttpGet("GetByProductName/{productName}")]
        public async Task<ActionResult<FeatureToggle>> GetProduct(string productName) 
        {
            var featureToggles = await _retrievalService.GetFeatureTogglesByProductName(productName);
            return StatusCode(201, featureToggles);
        }

        [HttpGet("GetByProductName/{productName}/{status}")]
        public async Task<ActionResult<FeatureToggle>> GetProduct(string productName, int featureToggleStatus)
        {
            var featureToggles = await _retrievalService.GetFeatureTogglesByProductNameAndStatus(productName, featureToggleStatus);
            return StatusCode(201, featureToggles);
        }
    }
}