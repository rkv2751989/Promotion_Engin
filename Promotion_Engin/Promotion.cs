using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Promotion_Engin
{
    public class Promotion : Ipromotion
    {
        public void Calculate(List<Product> products)
        {
                        
            int sumA = 0, sumB=0, sumC=0, sumD = 0;

            var groupList = products.GroupBy(i => i.Unit);

            foreach (var items in groupList)
            {
                switch (items.Key)
                {
                    case "A":
                       
                            int closestnumber =  closestNumber(items.Count(), 3);
                            int Discounted_Value_forA = closestnumber * 130;
                            int remaningItems = items.Count() - (closestnumber*3);

                            foreach (var item in items)
                            {
                            if (remaningItems == 0)
                                break;
                            
                            if(remaningItems!=0)
                            { 
                                sumA = sumA + item.Price;
                            }
                            remaningItems--;

                             }
                        sumA += Discounted_Value_forA;


                        break;
                    case "B":

                        int itemcnt = 0;

                        foreach (var item in items)
                        {

                            int rem = items.Count() / 2;

                            

                            itemcnt++;
                            if (items.Count() < 2)
                            {
                                sumB = sumB + item.Price;
                            }
                            else
                            {
                                //if ( == 2)
                                //{
                                //    sumB = 45;
                                //}
                                //else
                                //    sumB += item.Price;
                            }
                        }

                        break;

                    case "C":
                        foreach (var item in items)
                        {
                            sumC += item.Price;
                        }
                        break;

                    case "D":

                        foreach (var item in items)
                        {
                            sumD += item.Price;
                        }
                        break;
                }
                    }
        }

         int closestNumber(int n, int m)
        {
            int q = n / m;
            return q;
        }

    }

}
