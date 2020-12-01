using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.TransactionQueries
{
    public class GetTransactionByIdQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public Transaction GetTransactionById(int id)
        {
            var transactionById = context.Transactions.Where(a => a.Id == id).FirstOrDefault();

            return transactionById;
        }
    }
}
