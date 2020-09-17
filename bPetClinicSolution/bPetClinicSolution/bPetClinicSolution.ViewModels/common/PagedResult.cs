using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.ViewModels.common
{
    public class PagedResult<T>
    {
        //common dtos de tra ve chung
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
