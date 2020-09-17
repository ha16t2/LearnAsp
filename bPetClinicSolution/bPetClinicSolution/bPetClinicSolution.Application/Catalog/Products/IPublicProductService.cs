

using bPetClinicSolution.ViewModels.Catalog.Products;

using bPetClinicSolution.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bPetClinicSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
