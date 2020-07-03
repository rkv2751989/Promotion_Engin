using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion_Engin;

namespace Promotion_UnitTest
{
    [TestClass]
    public class Promotion_test
    {
        Promotion obj;

        [TestInitialize]
        public void testInit()
        {
            obj = new Promotion();

        }

        [TestMethod]
        public void When_ProvideEachsingleUnit()
        {

            Product p1 = new Product();
            p1.Unit = "A";
            p1.Price = Convert.ToInt16(util.Unit.A) ;

            Product p2 = new Product();
            p2.Unit = "B";
            p2.Price = Convert.ToInt16(util.Unit.B);

            Product p4 = new Product();
            p4.Unit = "A";
            p4.Price = Convert.ToInt16(util.Unit.A);

            Product p5 = new Product();
            p5.Unit = "A";
            p5.Price = Convert.ToInt16(util.Unit.A);


            Product p3 = new Product();
            p3.Unit = "C";
            p3.Price = Convert.ToInt16(util.Unit.C);

            List<Product> lstunit = new List<Product>();
            lstunit.Add(p1);
            lstunit.Add(p2);
            lstunit.Add(p3);
            lstunit.Add(p4);
            obj.calculation(lstunit);   
        
        }
    }
}
