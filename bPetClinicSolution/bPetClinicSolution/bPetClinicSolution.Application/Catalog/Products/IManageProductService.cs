
using bPetClinicSolution.ViewModels.Catalog.Products;
using bPetClinicSolution.ViewModels.common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bPetClinicSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest productCreateRequest);
        Task<int> Update(ProductUpdateRequest productEditRequest);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId);
       Task< List<ProductViewModel> >GetAll();
        //keyword to search
        //Task<PagedResult<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);//tra ve lít trong PagedViewModel
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
