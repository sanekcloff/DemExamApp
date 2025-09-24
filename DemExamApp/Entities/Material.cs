using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemExamApp.Entities
{
    public class Material
    {
        public Material()
        {
            Title = string.Empty;
            PricePerUnit = 0;
            CountOnStorage = 0;
            MinCount = 0;
            CountInPackage = 0;
            UnitOfMeasurement = string.Empty;
            MaterialType = null!;
        }
        public Material(string title, decimal pricePerUnit, decimal countOnStorage, decimal minCount, decimal countInPackage, string unitOfMeasurement, MaterialType materialType)
        {
            Title = title;
            PricePerUnit = pricePerUnit;
            CountOnStorage = countOnStorage;
            MinCount = minCount;
            CountInPackage = countInPackage;
            UnitOfMeasurement = unitOfMeasurement;
            MaterialType = materialType;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal CountOnStorage { get; set; }
        public decimal MinCount { get; set; }
        public decimal CountInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }

        public int MaterialTypeId { get; set; }
        public MaterialType MaterialType { get; set; }

        public ICollection<Supplier> Supplier { get; set; }

        public override string ToString() => $"{Id}: {Title} ({MaterialType}) - Price per unit: {PricePerUnit:C}, Count on storage: {CountOnStorage} {UnitOfMeasurement}, Min count: {MinCount} {UnitOfMeasurement}, {CountInPackage} {UnitOfMeasurement}";
    }
}
