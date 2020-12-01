using BoozewasherApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.TransactionQueries
{
    public class DeleteTransactionQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void DeleteTransaction(int id)
        {
            var transactionToDelete = context.Transactions.Where(a => a.Id == id).FirstOrDefault();
            if (transactionToDelete != null)
            {
                context.Transactions.Remove(transactionToDelete);
                context.SaveChanges();
            }
        }
    }
}
