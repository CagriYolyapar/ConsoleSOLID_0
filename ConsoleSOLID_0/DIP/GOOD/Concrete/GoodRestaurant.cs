using ConsoleSOLID_0.DIP.GOOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.GOOD.Concrete
{
    public class GoodRestaurant
    {
        //Bu versiyonda Restaurant sınıfı alt seviye modüllerden bagımsız bir hale gelecektir...Kendisine ne geliyorsa ona göre bir işlem gerçekleştireceğiz...

        List<IProduct> _products;

        public GoodRestaurant(List<IProduct> products)
        {

            //Tightly Coupled(sıkı sıkıya bagımlı olan) bir yapıyı burada loosely coupled(gevsek bir şekilde baglı olan) yapıya cevirmek icin Dependency INjection tasarım paternini (constructor based injection) kullandık...
            _products = products;
        }

        public string GenerateInstructions()
        {
            string instructions = null;

            foreach (IProduct item in _products)
            {
                instructions += item.GetCookingInstructions();
            }

            return instructions;
        }
    }
}
