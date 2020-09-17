using bPetClinicSolution.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
        
    }
}
