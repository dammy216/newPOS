using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class CartData
    {
        public string Name { get; set; }
        public int Amount {  get; set; }

        public CartData(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
