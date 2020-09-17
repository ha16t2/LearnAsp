using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.ViewModels.common
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
