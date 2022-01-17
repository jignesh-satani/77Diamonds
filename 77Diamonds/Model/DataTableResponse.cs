using System.Collections.Generic;

namespace _77Diamonds.API.Model
{
    public class DataTableResponse<T> where T : class
    {
        public string draw { get; set; } = string.Empty;
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IEnumerable<T>? data { get; set; }
    }
}
