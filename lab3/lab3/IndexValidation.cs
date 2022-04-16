using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab3
{
    class IndexValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Flat flat = value as Flat;
            if (flat.Addres.Index == 000000 || flat.Addres.Index == 111111 ||
                flat.Addres.Index == 222222 || flat.Addres.Index == 333333 ||
                flat.Addres.Index == 444444 || flat.Addres.Index == 555555 ||
                flat.Addres.Index == 666666 || flat.Addres.Index == 777777 ||
                flat.Addres.Index == 888888 || flat.Addres.Index == 999999)
            {
                ErrorMessage = "В индексе все цифры не могут быть одинаковыми!!!";
                return false;
            }
            return true;
        }
    }
}
