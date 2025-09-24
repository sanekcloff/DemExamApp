using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemExamApp.Entities
{
    public class MaterialType
    {
        public MaterialType()
        {
            Title = string.Empty;
            Percent = 0.0M;
        }
        public MaterialType(string title, decimal ratio)
        {
            Title = title;
            Percent = ratio;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Percent { get; set; }

        public override string ToString() => $"{Id}: {Title} - {Percent}%";
    }
}
