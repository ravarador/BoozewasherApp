using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.TransactionQueries
{
    public class AddTransactionQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void AddTransaction(Transaction transaction)
        {
            context.Transactions.Add(transaction);
            context.SaveChanges();
        }
    }
}
