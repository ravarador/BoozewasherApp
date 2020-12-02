using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.TransactionQueries
{
    public class GetAllTransactionsQuery
    {
        private DatabaseContext context = new DatabaseContext();
        public List<Transaction> GetAllTransactions()
        {
            var transactions = context.Transactions.Include("Service")
                                                   .Include("Vehicle")
                                                   .ToList();

            return transactions;
        }
    }
}
