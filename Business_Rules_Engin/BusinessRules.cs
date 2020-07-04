using System;

namespace Business_Rules_Engin
{
    public class BusinessRules
    {
        int payment = 0;
         
        
        public void calculation()
        { 
        



        switch (payment)
         {
                case (int)PaymentTypeEnum.Payment.Physical_Product:
                    break;
                case (int)PaymentTypeEnum.Payment.Book:
                    break;
                case (int)PaymentTypeEnum.Payment.MemberShip:
                    break;


            }
        }
    }



    
}
