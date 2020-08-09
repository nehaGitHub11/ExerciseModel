using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NehaExerciseModel
{
    public class Product
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
    }

}
