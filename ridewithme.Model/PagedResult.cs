using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class PagedResult<T>
    {
        public int? Count { get; set; }
        public IList<T> Results { get; set; }
    }
}
