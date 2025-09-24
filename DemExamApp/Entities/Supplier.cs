using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DemExamApp.Entities
{
    public class Supplier
    {
        public Supplier() 
        {
            Title = string.Empty;
            Type = string.Empty;
            INN = string.Empty;
            Rating = 0;
            StartDateOfCollaboration = DateTime.Now;
        }

        public Supplier(string title, string type, string iNN, byte rating, DateTime startDateOfCollaboration)
        {
            Title = title;
            Type = type;
            INN = iNN;
            Rating = rating;
            StartDateOfCollaboration = startDateOfCollaboration;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string INN { get; set; }
        public byte Rating { get; set; }
        public DateTime StartDateOfCollaboration { get; set; }

        public ICollection<Material> Material { get; set; }

        public override string ToString() => $"{Id}: {Title} - {Type}, {INN}, Rating = {Rating}, {StartDateOfCollaboration.ToShortDateString()}";
    }
}
