using BoozewasherApp.Context;
using BoozewasherApp.Models.ContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Queries.TransactionQueries
{
    public class UpdateTransactionQuery
    {
        private DatabaseContext context = new DatabaseContext();

        public void UpdateTransaction(Transaction transaction)
        {
            var transactionToUpdate = context.Transactions.Where(a => a.Id == transaction.Id).FirstOrDefault();

            transactionToUpdate.DateTime = transaction.DateTime;
            transactionToUpdate.ServiceId = transaction.ServiceId;
            transactionToUpdate.VehicleId = transaction.VehicleId;
            transactionToUpdate.PlateNumber = transaction.PlateNumber;
            transactionToUpdate.Cost = transaction.Cost;

            context.SaveChanges();
        }
    }
}
