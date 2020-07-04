using System;

namespace Business_Rules_Engin
{
    public class BusinessRules
    {
        int payment = 0;
         
        
        public void calculation()
        {

            string sliptype = "";


        switch (payment)
         {
                case (int)PaymentTypeEnum.Payment.Physical_Product:
                    sliptype = "Packing slip for shipping";
                    break;
                case (int)PaymentTypeEnum.Payment.Book:
                    sliptype = "";
                    break;
                case (int)PaymentTypeEnum.Payment.MemberShip:
                    break;


            }
        }
    }



    
}
