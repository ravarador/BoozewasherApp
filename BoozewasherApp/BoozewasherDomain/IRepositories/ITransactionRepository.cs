using BoozewasherApp.Models.ContextModels;
using BoozewasherApp.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.IRepositories
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        List<Transaction> GetAllTransactions();
        void UpdateTransaction(Transaction transaction);
        List<Transaction> GetTransactionsByDateRange(SummaryDateAndDateRangeDto dateAndDateRangeDto);
        List<Transaction> GetTransactionsByDate(SummaryDateAndDateRangeDto dateAndDateRangeDto);

    }
}
