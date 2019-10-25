using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameshop.Data.Models
{
    public class OrderDetail
    {
        public int ID { set; get; }
        public int orderID { get; set; }
        public int GameID { get; set; }
        public uint price { get; set; }
        public virtual Game game { get; set; }  
        public virtual Order order { get; set; }

 
    }
}
