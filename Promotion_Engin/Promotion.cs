﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Promotion_Engin
{
    public class Promotion : Ipromotion
    {
        public void Calculate(List<Product> products)
        {
                        
            int sumA = 0, sumB, sumC, subD = 0;

            var groupList = products.GroupBy(i => i.Unit);

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
                                if (itemcount == 3)
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
                            else if (items.Count() == 2)
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

}
