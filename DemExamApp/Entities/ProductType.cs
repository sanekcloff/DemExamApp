using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemExamApp.Entities
{
    public class ProductType
    {
        public ProductType()
        {
            Title = string.Empty;
            Ratio = 0.0M;
        }
        public ProductType(string title, decimal ratio)
        {
            Title = title;
            Ratio = ratio;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Ratio { get; set; }

        public override string ToString() => $"{Id}: {Title} - {Ratio}";
    }
}
