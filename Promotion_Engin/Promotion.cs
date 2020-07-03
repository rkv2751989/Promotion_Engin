using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Promotion_Engin
{
    public class Promotion
    {


        public void calculation(List<Product> product)
        {
            int sumA = 0, sumB, sumC, subD = 0;
            var g = product.GroupBy(i => i.Unit);

            foreach (var items in g)
            {

                switch (items.Key)
                {
                    case "A":

                        int itemcount = 0;

                        foreach (var item in items)
                        {
                            itemcount++;
                            if (items.Count() < 3)
                            {
                                sumA = sumA + item.Price;
                            }
                            else 
                            {
                                sumA = 130 + item.Price;
                            }
                        }


                        break;
                    case "B":
                        break;









                }





            }
        }


    }


    public class Product
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public bool status { get; set; }
    
    }

}
