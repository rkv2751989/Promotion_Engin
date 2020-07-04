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
            
            var groupList = product.GroupBy(i => i.Unit);

            foreach (var items in groupList)
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
                                if(itemcount ==3)
                                {
                                    sumA = 130;
                                }
                                else
                                sumA += item.Price;
                            }
                        }


                        break;
                    case "B":

                        int itemcnt = 0;

                        foreach (var item in items)
                        {
                            itemcnt++;
                            if (items.Count() > 2)
                            {
                                sumA = sumA + item.Price;
                            }
                            else if(items.Count()==2)
                            {

                            }


                        }



                        break;

                    case "C":
                    case "D":






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
