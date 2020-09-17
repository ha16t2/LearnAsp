using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bPetClinicSolution.Application.Catalog.Products;
using bPetClinicSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bPetClinicSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }
        //http://localhost:port/product
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products =await _publicProductService.GetAll();
            return Ok(products);
        }
        //http://localhost:port/product/public-paging
        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }

        //http://localhost:port/product/id
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _manageProductService.GetById(productId);
            if (product == null)
            {
                return BadRequest("Cannot find product");
            }
            return Ok(product);
           
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }
            var product = await _manageProductService.GetById(productId);
            return CreatedAtAction(nameof(GetById),new { id=productId}, product);
            //can mad tu product sang productModel
        }
        [HttpPut]
        public async Task<IActionResult>Update([FromBody]ProductUpdateRequest request)
        {
            var effectedRequest = await _manageProductService.Update(request);
            if (effectedRequest == 0)
            {

                return BadRequest();

            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var effectedRequest = await _manageProductService.Delete(id);
            if (effectedRequest == 0)
            {

                return BadRequest();

            }
            return Ok();
        }
        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id,newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
                
            
            return BadRequest();

        }
    }
}
