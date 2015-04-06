using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMoney.Core
{
    public class Expense
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
