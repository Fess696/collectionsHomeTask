using System;
using Newtonsoft.Json;
using JsonSeDe;
using System.Collections.Generic;

namespace JsonSeDe
{
    [Serializable]
    public class ProductList 
    {
        public string? Id { get; set; }

        public string  Name { get; set; }

        public string? Description { get; set; }

        public string? CategoryId { get; set; }

        public string? Factory { get; set; }

        public string? Supplier { get; set; }

        public decimal? Price { get; set; }
        
    }
}

