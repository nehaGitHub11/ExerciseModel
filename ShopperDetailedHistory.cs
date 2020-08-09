using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NehaExerciseModel
{
    public class ShopperHistory
    {
        [JsonProperty(PropertyName = "customerId")]
        public int CustomerId { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
   
}
