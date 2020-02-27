using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaLab3.Models
{
    public class MedicationModel : IComparable
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Producer { get; set; }
        public double Price { get; set; }
        public int Existence { get; set; }

        public int CompareTo(object obj)
        {
            var comparable = (MedicationModel)obj;
            return id.CompareTo(comparable.id);
        }
    }
}