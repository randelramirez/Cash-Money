using CashMoney.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMoney.Infrastructure
{
    public class CashMoneyContext :DbContext
    {
        public DbSet<Income> Gross { get; set; }

        public DbSet<Expense> Incomes { get; set; }
    }
}
