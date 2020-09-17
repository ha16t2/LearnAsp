using bPetClinicSolution.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
