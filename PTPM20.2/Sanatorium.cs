using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTPM20
{
    public class Sanatorium : Travel_Package
    {
        private string disease;
        public string Disease
        {
            get { return disease; }
            set { disease = value; }
        }
        public Sanatorium(string name, int duration, int price, string availability_of_excursions, string disease) : base(name, duration, price, availability_of_excursions)
        {
            this.disease = disease;
        }
        public override string Info()
        {
            return base.Info() + $"Заболевание: {disease}";
        }
    }

}
