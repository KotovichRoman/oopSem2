using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab3
{
    [Serializable]
    [IndexValidation]
    public class Addres
    {
        public int Index;

        public string Country;

        [Required(ErrorMessage = "Укажите город")]
        [StringLength(20)]
        public string City;

        [Required(ErrorMessage = "Укажите район")]
        [StringLength(20)]
        public string District;

        [Required(ErrorMessage = "Укажите улицу")]
        [StringLength(30)]
        public string Street;

        public int House;

        public int FlatNumber;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
