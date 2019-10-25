using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int ID { set; get; }
        [Display(Name="Введите имя")]
        [MinLength(3,ErrorMessage = "Длина имени не менее 3 символов")]
        public string name { get; set;  }

        [Display(Name = "Фамилия")]
        [MinLength(5, ErrorMessage = "Длина фамилии не менее 5 символов")]
      
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [MinLength(5, ErrorMessage = "Длина адреса не менее 5 символов")]
        public string address { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10, ErrorMessage = "Длина номера не менее 10 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(15, ErrorMessage = "Длина почты не менее 15 символов")]
        public string email { get; set; }

        [BindNever]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
