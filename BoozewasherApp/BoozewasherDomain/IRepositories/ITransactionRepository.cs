
using BoozewasherDomain.Dtos;
using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        List<TransactionDto> GetAllTransactions();
        List<TransactionDto> GetTransactionsByBranchId(int id);
        void UpdateTransaction(Transaction transaction);
        List<Transaction> GetTransactionsByDateRange(SummaryDateAndDateRangeDto dateAndDateRangeDto);
        List<Transaction> GetTransactionsByDate(SummaryDateAndDateRangeDto dateAndDateRangeDto);

    }
}
