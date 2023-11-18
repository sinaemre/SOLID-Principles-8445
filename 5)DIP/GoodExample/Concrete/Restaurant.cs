using _5_DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.GoodExample.Concrete
{
    public class Restaurant
    {
        //Bu işleme(Constructor'da başka bir interface'i çağırıp ondan dnesne oluşturmak ve private bir field'a aktarak özelliklerini kullanmak) Dependency Injection(DI) denir.


        private readonly IProduct _product;

        public Restaurant(IProduct product)
        {
            _product = product;
        }


        public string GenerateCookingIntroduction() => $"{_product.GetCookingIntroduction()}";
    }
}
