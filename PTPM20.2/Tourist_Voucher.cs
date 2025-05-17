using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTPM20
{
    public class Tourist_Voucher : Travel_Package
    {
        private string routeCategory;
        public string RouteCategory
        {
            get { return routeCategory; }
            set { routeCategory = value; }
        }
        private string certificate;
        public string Certificate
        {
            get { return certificate; }
            set { certificate = value; }
        }

        public Tourist_Voucher(string name, int duration, int price, string availability_of_excursions, string routeCategory, string certificate) : base(name, duration, price, availability_of_excursions)
        {
            this.routeCategory = routeCategory;
            this.certificate = certificate;
        }
        public override string Info()
        {
            return base.Info() + $"Категория маршрута {routeCategory}. Наличие сравки от врача: {certificate}";
        }
    }
}
