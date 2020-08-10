using System;
using System.Collections.Generic;
using System.Text;

namespace NehaExerciseModel
{
    public class Trolley
    {
        public List<Product> products { get; set; }

        public List<Specials> specials { get; set; }

        public List<Quantities> quantities { get; set; }
    }

    public class Quantities
    { 
    public string name { get; set; }

    public decimal quantity { get; set; }
    }

    public class Specials
    {
        public List<Quantities>  quantities { get; set; }

        public decimal total { get; set; }
    }
}
